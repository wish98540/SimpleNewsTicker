using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleNewsTicker
{
    public partial class Form1 : Form
    {
        private int lblText3_X;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 取得方向性, 是否爲 右 -> 左 (<<)
        /// </summary>
        private bool IsRightToLeft => tsslDirection.Text == "<<";

        /// <summary>
        /// 背景色按鈕, 背景色改變事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBackgroundColor1_BackColorChanged(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                _ = int.TryParse($"{btn.Tag}", out int seq);

                // find container
                var con = panelBody.Controls.Find($"groupBox{seq}", true).FirstOrDefault();
                if (con is GroupBox gb)
                {
                    // change container backColor
                    gb.BackColor = btn.BackColor;
                }
            }
        }

        /// <summary>
        /// 前景色按鈕, 背景色改變事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnForeColor1_BackColorChanged(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                _ = int.TryParse($"{btn.Tag}", out int seq);

                // find Label
                var gb = panelBody.Controls.Find($"groupBox{seq}", true).FirstOrDefault() as GroupBox;
                var con = panelBody.Controls.Find($"lblText{seq}", true).FirstOrDefault();
                if (con is Label label)
                {
                    // change Label foreColor
                    label.ForeColor = btn.BackColor;

                    // change groupBox foreColor
                    if (gb != null)
                        gb.ForeColor = btn.BackColor;
                }
            }
        }

        /// <summary>
        /// 顏色按鈕, 點擊事件。開啓調色盤。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnForeColor1_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                // set current color
                colorDialog1.Color = btn.BackColor;

                // select color from dialog
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    var color = colorDialog1.Color;
                    btn.BackColor = color;
                }
            }
        }

        /// <summary>
        /// 視窗加載中事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmNewsTicker_Load(object sender, EventArgs e)
        {
            InitFields();

            // register event
            RegisterEvents();
        }

        /// <summary>
        /// 視窗尺寸，改變事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmNewsTicker_SizeChanged(object sender, EventArgs e)
        {
            // Re-Calculate trackBar width
            trackBar1.Width = lblSpeed.Right - trackBar1.Left;
        }

        /// <summary>
        /// 初始化視窗元件
        /// </summary>
        private void InitFields()
        {
            // Init TrackBar
            lblMinValue.Text = trackBar1.Minimum.ToString();
            lblMaxValue.Text = trackBar1.Maximum.ToString();
            lblSpeed.Text = trackBar1.Value.ToString();

            // set groupbox background color
            btnBackgroundColor1.BackColor = Color.Crimson;
            btnBackgroundColor2.BackColor = Color.MediumBlue;
            btnBackgroundColor3.BackColor = Color.SeaGreen;

            // set groupbox foreColor
            btnForeColor1.BackColor = Color.WhiteSmoke;
            btnForeColor2.BackColor = Color.WhiteSmoke;
            btnForeColor3.BackColor = Color.WhiteSmoke;

            // set label background color
            lblText1.BackColor = Color.Transparent;
            lblText2.BackColor = Color.Transparent;
            lblText3.BackColor = Color.Transparent;

            // set label fontStyle
            lblText1.Font = new Font(lblText1.Font, FontStyle.Bold);
            lblText2.Font = new Font(lblText2.Font, FontStyle.Bold);
            lblText3.Font = new Font(lblText3.Font, FontStyle.Bold);

            // show font
            var font = lblText1.Font;
            tsslFont.Text = $"{font.Name}, {font.Size}pt, {font.Style}";

            // set direction
            tsslDirection.Text = ">>";

            // Hide lblText3
            lblText3.Hide();
        }

        /// <summary>
        /// 滾動文字, 雙擊事件 (切換 全螢幕/一般模式)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblText1_DoubleClick(object sender, EventArgs e)
        {
            var obj = sender as Control;
            var container = obj.Parent;
            var dock = container.Dock;

            if (dock == DockStyle.Fill)
            {
                // switch to Dock.Top
                foreach (Control con in panelBody.Controls)
                {
                    con.Dock = DockStyle.Top;
                    con.Visible = true;
                }
            }
            else
            {
                // switch to Dock.None
                foreach (Control con in panelBody.Controls)
                {
                    con.Dock = DockStyle.None;
                    con.Visible = false;
                }

                // change current container's Dock to Dock.Fill
                container.Dock = DockStyle.Fill;
                container.Visible = true;
            }

            Debug.WriteLine($"{container.Name}, {container.Dock}");
        }

        /// <summary>
        /// 動態註冊事件
        /// </summary>
        private void RegisterEvents()
        {
            // 註冊 視窗大小, 改變事件
            SizeChanged += FrmNewsTicker_SizeChanged;
        }

        /// <summary>
        /// Label 的文字位移
        /// </summary>
        private void RenderLabel1()
        {
            _ = int.TryParse($"{lblText1.Tag}", out int recycleCounts);
            var originText = txtText.Text;
            var text = lblText1.Text;
            var whiteSpace = "　"; // 全形空白, 移動速度較快
            var newText = IsRightToLeft ? $"{text}{whiteSpace}" : $"{whiteSpace}{text}";
            var newWidth = TextRenderer.MeasureText(newText, lblText1.Font).Width;
            var hasEllipsis = newWidth > lblText1.Width;

            // 使用了縮略符號 (Ellipisis)
            if (hasEllipsis)
            {
                // 判斷方向性
                // 右 -> 左: 首字元加到最後一個位置
                // 左 -> 右: 最後字元加到第一個位置
                newText = IsRightToLeft
                    ? text.Substring(1) + text[0]
                    : text.Last() + text.Substring(0, text.Length - 1);
            }

            // todo 平滑滾動, 滾動離開畫面才繼續滾動。

            lblText1.Text = newText;
            //Debug.WriteLine($"Label1:\n{newText}");
        }

        /// <summary>
        /// 整個 Label 位移
        /// </summary>
        private void RenderLabel2()
        {
            var loc2 = lblText2.Location;
            var whiteSpaceSize = TextRenderer.MeasureText(" ", lblText2.Font);
            var whiteSpaceWidth = whiteSpaceSize.Width;

            // 計算新的位置
            var newLoc2_X = IsRightToLeft
                ? loc2.X - whiteSpaceWidth
                : loc2.X + whiteSpaceWidth;
            var newLoc2_Y = (panel2.Height - whiteSpaceSize.Height) / 2;

            // 判斷方向性, 如果文字滾出顯示範圍, 則重新定位
            var isText2Visible = IsRightToLeft
                ? lblText2.Right > 0                // 右 -> 左: 右邊界 > 0
                : lblText2.Left < groupBox2.Right; // 左 -> 右: 左邊界 < 右邊界 (平滑滾出)
            if (!isText2Visible)
                newLoc2_X = IsRightToLeft
                    ? groupBox2.Right                   // 右 -> 左: 從 右邊界 滾出
                    : groupBox2.Left - lblText2.Width;  // 左 -> 右: 從 左邊界 滾出 (左邊界 - 文字寬度; 平滑滾出)

            lblText2.Location = new Point(newLoc2_X, newLoc2_Y);
        }

        /// <summary>
        /// 使用 Drawing 繪製 => 會有 "閃爍" 發生
        /// </summary>
        private void RenderLabel3()
        {
            // 清除 Inner Container 的內容
            var g = panel3.CreateGraphics();
            g.Clear(btnBackgroundColor3.BackColor);

            // 繪製文字內容
            var text = txtText.Text;
            var whiteSpaceWidth = TextRenderer.MeasureText(" ", lblText3.Font).Width;
            var textWidth = TextRenderer.MeasureText(text, lblText3.Font).Width;
            var loc3_X = lblText3_X;
            var loc3_Y = (groupBox3.Height - lblText3.Height) / 2;

            // 判斷方向性
            // 右 -> 左
            // 左 -> 右
            var newLoc3_X = IsRightToLeft
                ? loc3_X - whiteSpaceWidth
                : loc3_X + whiteSpaceWidth;
            var isText3Visible = IsRightToLeft
                ? newLoc3_X + textWidth > 0 // 右 -> 左: 右邊界 > 0 (X座標 + 文字寬度; 平滑滾出)
                : newLoc3_X < panel3.Right; // 左 -> 右: X座標 < 右邊界
            if (!isText3Visible)
                newLoc3_X = IsRightToLeft
                    ? panel3.Right              // 右 -> 左: 從 右邊界 滾出
                    : panel3.Left - textWidth;  // 左 -> 右: 從 左邊界 滾出 (左邊界 - 文字寬度; 平滑滾出)

            var newLoc3 = new Point(newLoc3_X, loc3_Y);
            var brush = new SolidBrush(btnForeColor3.BackColor);
            g.DrawString(text, lblText3.Font, brush, newLoc3);

            // update new loc3_X
            lblText3_X = newLoc3_X;
        }

        /// <summary>
        /// 設定跑馬燈字型
        /// </summary>
        private void SetFont()
        {
            // set base-font
            fontDialog1.Font = lblText1.Font;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                var font = fontDialog1.Font;

                // set Labels font
                lblText1.Font
                    = lblText2.Font
                    = lblText3.Font
                    = font;

                // show font
                tsslFont.Text = $"{font.Name}, {font.Size}pt, {font.Style}";
            }
        }

        /// <summary>
        /// Timer 觸發事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                timer1.Stop();

                // 1. Label 的文字位移
                RenderLabel1();

                // 2. 整個 Label 位移
                RenderLabel2();

                // 3. 使用 Drawing 繪製 => 會有 "閃爍" 發生
                RenderLabel3();
            }
            finally
            {
                timer1.Start();
            }
        }

        /// <summary>
        /// 滑桿控制項, 滑動事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            DoTrackBarScroll();
        }

        /// <summary>
        /// 修改 速度滑桿 的值
        /// </summary>
        private void DoTrackBarScroll()
        {
            // Update Speed
            lblSpeed.Text = trackBar1.Value.ToString();

            // Set Timer Interval
            var originalInterval = 1100; // 預設爲 1.1 秒, 由 1000 -> 100 ms
            timer1.Interval = originalInterval - trackBar1.Value * 100; // max speed is 100 ms

            // Set Timer enable if interval > 0, and Text is not empty.
            timer1.Enabled = trackBar1.Value > 0 && !string.IsNullOrEmpty(txtText.Text);

            // set tsmiSpeed
            tsmiSpeed.SelectedIndex = trackBar1.Value;
        }

        /// <summary>
        /// 右鍵選單, 方向性修改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            tsslDirection.Text = tsmiDirection.SelectedIndex == 0 ? ">>" : "<<";
            contextMenuStrip1.Close(ToolStripDropDownCloseReason.Keyboard);
        }

        /// <summary>
        /// 右鍵選單, 設定字型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiFont_Click(object sender, EventArgs e)
        {
            SetFont();
            contextMenuStrip1.Close(ToolStripDropDownCloseReason.Keyboard);
        }

        /// <summary>
        /// 方向性, 修改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsslDirection_TextChanged(object sender, EventArgs e)
        {
            var direction = tsslDirection.Text;

            tsmiDirection.SelectedIndex = direction == ">>" ? 0 : 1;
        }

        /// <summary>
        /// 設定字體
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsslFont_Click(object sender, EventArgs e)
        {
            SetFont();
        }

        /// <summary>
        /// 字體, 修改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsslFont_TextChanged(object sender, EventArgs e)
        {
            tsmiFont.Text = tsslFont.Text;
        }

        /// <summary>
        /// 文字方向, 左 -> 右
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsslLeftToRight_Click(object sender, EventArgs e)
        {
            tsslDirection.Text = ">>";
        }

        /// <summary>
        /// 文字方向, 右 -> 左
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsslRightToLeft_Click(object sender, EventArgs e)
        {
            tsslDirection.Text = "<<";
        }

        /// <summary>
        /// 右鍵選單, 文字修改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tstxtText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtText.Text = tstxtText.Text.Trim();
                contextMenuStrip1.Close(ToolStripDropDownCloseReason.Keyboard);
            }
        }

        /// <summary>
        /// 文字修改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtText_TextChanged(object sender, EventArgs e)
        {
            // if text has value, start timer
            if (!timer1.Enabled)
            {
                timer1.Enabled = txtText.TextLength > 0;
                ScrollTrackBar(1);
            }

            // set text
            lblText1.Text = txtText.Text;
            lblText2.Text = txtText.Text;
            lblText3.Text = txtText.Text;

            // reset text location
            var x2 = (groupBox2.Width - lblText2.Width) / 2;
            var y2 = (groupBox2.Height - lblText2.Height) / 2;
            lblText2.Dock = DockStyle.None;
            lblText2.AutoSize = true;
            lblText2.Location = new Point(x2, y2);

            // align Label3 with Label2
            lblText3_X = x2;

            // cache text
            tstxtText.Text = txtText.Text;
        }

        /// <summary>
        /// 修改 TrackBar 的值
        /// </summary>
        /// <param name="value"></param>
        private void ScrollTrackBar(int value)
        {
            // 因爲直接修改 Value 不會觸發 Scroll 事件, 因此封裝 Scroll 功能
            trackBar1.Value = value;
            DoTrackBarScroll();
        }

        /// <summary>
        /// 右鍵選單, 速度修改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiSpeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            ScrollTrackBar(tsmiSpeed.SelectedIndex);
            contextMenuStrip1.Close(ToolStripDropDownCloseReason.Keyboard);
        }
    }
}
