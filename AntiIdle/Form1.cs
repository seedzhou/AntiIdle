using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntiIdle
{
    public partial class Form1 : Form
    {
        private const int minute = 60000;

        public Form1()
        {
            InitializeComponent();
            AntiIdleIcon.ContextMenuStrip = contextMenuStrip;
            timer.Interval = 299000;
            timer.Enabled = true;
            timer1.Enabled = false;
            toolStripMenuItem_Click(fourHoursToolStripMenuItem, null);
        }

        private void TimerOnTick(object sender, EventArgs eventArgs)
        {
            SendInputClass.MoveMouse();
        }

        private bool allowVisible;     // ContextMenu's Show command used
        private bool allowClose;       // ContextMenu's Exit command used

        protected override void SetVisibleCore(bool value)
        {
            if (!allowVisible)
            {
                value = false;
                if (!this.IsHandleCreated) CreateHandle();
            }
            base.SetVisibleCore(value);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!allowClose)
            {
                this.Hide();
                e.Cancel = true;
            }
            base.OnFormClosing(e);
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allowVisible = true;
            Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AntiIdleIcon.Icon = null;
            AntiIdleIcon.Dispose();
            allowClose = true;
            Application.Exit();
        }

        private void toolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripTextBox)
            {
                sender = customizedToolStripMenuItem;
            }

            ResetAllToolStripMenuItems((ToolStripMenuItem)sender);
            int delayTime = GetDelayTime((ToolStripMenuItem)sender);

            timer1.Interval = delayTime;
            timer1.Enabled = true;

            statusToolStripMenuItem.Text = "Status: Enabled";
            actionAfterToolStripMenuItem.Text = "Pause After";
            nowToolStripMenuItem.Visible = true;
            timer.Enabled = true;

            if (sender == neverToolStripMenuItem)
            {
                timer1.Enabled = false;
            }
        }

        private int GetDelayTime(ToolStripMenuItem sender)
        {
            var delayTime = 180 * minute;

            if (sender == nowToolStripMenuItem)
            {
                delayTime = 1000;
            }
            else if (sender == fiveMinsToolStripMenuItem)
            {
                delayTime = 5 * minute;
            }
            else if (sender == tenMinsToolStripMenuItem)
            {
                delayTime = 10 * minute;
            }
            else if (sender == twentyMinsToolStripMenuItem)
            {
                delayTime = 20 * minute;
            }
            else if (sender == thirtyMinsToolStripMenuItem)
            {
                delayTime = 30 * minute;
            }
            else if (sender == oneHourToolStripMenuItem)
            {
                delayTime = 60 * minute;
            }
            else if (sender == twoHoursToolStripMenuItem)
            {
                delayTime = 120 * minute;
            }
            else if (sender == threeHoursToolStripMenuItem)
            {
                delayTime = 180 * minute;
            }
            else if (sender == fourHoursToolStripMenuItem)
            {
                delayTime = 240 * minute;
            }
            else if (sender == eightHoursToolStripMenuItem)
            {
                delayTime = 480 * minute;
            }
            else if (sender == customizedToolStripMenuItem)
            {
                delayTime = Convert.ToInt32(toolStripTextBox.Text) * minute;
            }

            return delayTime;
        }

        private void ResetAllToolStripMenuItems(ToolStripMenuItem toolStripMenuItem)
        {
            SetToolStripMenuItem(nowToolStripMenuItem, toolStripMenuItem);
            SetToolStripMenuItem(fiveMinsToolStripMenuItem, toolStripMenuItem);
            SetToolStripMenuItem(tenMinsToolStripMenuItem, toolStripMenuItem);
            SetToolStripMenuItem(twentyMinsToolStripMenuItem, toolStripMenuItem);
            SetToolStripMenuItem(thirtyMinsToolStripMenuItem, toolStripMenuItem);
            SetToolStripMenuItem(oneHourToolStripMenuItem, toolStripMenuItem);
            SetToolStripMenuItem(twoHoursToolStripMenuItem, toolStripMenuItem);
            SetToolStripMenuItem(threeHoursToolStripMenuItem, toolStripMenuItem);
            SetToolStripMenuItem(fourHoursToolStripMenuItem, toolStripMenuItem);
            SetToolStripMenuItem(eightHoursToolStripMenuItem, toolStripMenuItem);
            SetToolStripMenuItem(customizedToolStripMenuItem, toolStripMenuItem);
            SetToolStripMenuItem(neverToolStripMenuItem, toolStripMenuItem);
        }

        private void SetToolStripMenuItem(ToolStripMenuItem toolStripMenuItem, ToolStripMenuItem clickedToolStripMenuItem)
        {
            toolStripMenuItem.Checked = toolStripMenuItem == clickedToolStripMenuItem;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            statusToolStripMenuItem.Text = "Status: Disabled";
            actionAfterToolStripMenuItem.Text = "Resume and Pause After";
            nowToolStripMenuItem.Visible = false;
            timer.Enabled = false;
        }
    }

    public static class SendInputClass
    {

        [DllImport("user32.dll", SetLastError = true)]
        static extern uint SendInput(uint nInputs, ref INPUT pInputs, int cbSize);

        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int X, int Y);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetCursorPos(out Point lpPoint);



        [StructLayout(LayoutKind.Sequential)]
        struct INPUT
        {
            public SendInputEventType type;
            public MouseKeybdhardwareInputUnion mkhi;
        }
        [StructLayout(LayoutKind.Explicit)]
        struct MouseKeybdhardwareInputUnion
        {
            [FieldOffset(0)]
            public MouseInputData mi;

            [FieldOffset(0)]
            public KEYBDINPUT ki;

            [FieldOffset(0)]
            public HARDWAREINPUT hi;
        }
        [StructLayout(LayoutKind.Sequential)]
        struct KEYBDINPUT
        {
            public ushort wVk;
            public ushort wScan;
            public uint dwFlags;
            public uint time;
            public IntPtr dwExtraInfo;
        }
        [StructLayout(LayoutKind.Sequential)]
        struct HARDWAREINPUT
        {
            public int uMsg;
            public short wParamL;
            public short wParamH;
        }
        struct MouseInputData
        {
            public int dx;
            public int dy;
            public uint mouseData;
            public MouseEventFlags dwFlags;
            public uint time;
            public IntPtr dwExtraInfo;
        }
        [Flags]
        enum MouseEventFlags : uint
        {
            MOUSEEVENTF_MOVE = 0x0001,
            MOUSEEVENTF_LEFTDOWN = 0x0002,
            MOUSEEVENTF_LEFTUP = 0x0004,
            MOUSEEVENTF_RIGHTDOWN = 0x0008,
            MOUSEEVENTF_RIGHTUP = 0x0010,
            MOUSEEVENTF_MIDDLEDOWN = 0x0020,
            MOUSEEVENTF_MIDDLEUP = 0x0040,
            MOUSEEVENTF_XDOWN = 0x0080,
            MOUSEEVENTF_XUP = 0x0100,
            MOUSEEVENTF_WHEEL = 0x0800,
            MOUSEEVENTF_VIRTUALDESK = 0x4000,
            MOUSEEVENTF_ABSOLUTE = 0x8000
        }
        enum SendInputEventType : int
        {
            InputMouse,
            InputKeyboard,
            InputHardware
        }

        public static void ClickLeftMouseButton(int x, int y)
        {
            INPUT mouseInput = new INPUT();
            mouseInput.type = SendInputEventType.InputMouse;
            mouseInput.mkhi.mi.dx = x;
            mouseInput.mkhi.mi.dy = y;
            mouseInput.mkhi.mi.mouseData = 0;

            //getting current cursor location
            Point p;
            if (GetCursorPos(out p))
                SetCursorPos(x, y);


            mouseInput.mkhi.mi.dwFlags = MouseEventFlags.MOUSEEVENTF_LEFTDOWN;
            SendInput(1, ref mouseInput, Marshal.SizeOf(new INPUT()));

            mouseInput.mkhi.mi.dwFlags = MouseEventFlags.MOUSEEVENTF_LEFTUP;
            SendInput(1, ref mouseInput, Marshal.SizeOf(new INPUT()));

            //returning cursor to previous position
            SetCursorPos(p.X, p.Y);
        }

        public static void MoveMouse()
        {
            //getting current cursor location
            Point p;
            GetCursorPos(out p);

            INPUT input = new INPUT();
            input.type = SendInputEventType.InputMouse;
            input.mkhi.mi.dx = p.X;
            input.mkhi.mi.dy = p.Y;
            input.mkhi.mi.mouseData = 0;

            input.mkhi.mi.dwFlags = MouseEventFlags.MOUSEEVENTF_MOVE;
            //SendInput(1, ref input, Marshal.SizeOf(new INPUT()));

            input.type = SendInputEventType.InputKeyboard;
            input.mkhi.ki.wVk = 0x90;
            input.mkhi.ki.dwFlags = 0x0002;
            //SendInput(1, ref input, Marshal.SizeOf(new INPUT()));
            SendInput(1, ref input, Marshal.SizeOf(new INPUT()));

            //returning cursor to previous position
            SetCursorPos(p.X, p.Y);
        }
    }
}
