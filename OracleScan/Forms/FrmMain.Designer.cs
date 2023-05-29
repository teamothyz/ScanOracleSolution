namespace OracleScan.Forms
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.LoadProxyBtn = new Krypton.Toolkit.KryptonButton();
            this.LoadDataBtn = new Krypton.Toolkit.KryptonButton();
            this.StartBtn = new Krypton.Toolkit.KryptonButton();
            this.StopBtn = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.TotalAccountsTextBox = new Krypton.Toolkit.KryptonTextBox();
            this.SuccessAccountsTextBox = new Krypton.Toolkit.KryptonTextBox();
            this.FailedAccountsTextBox = new Krypton.Toolkit.KryptonTextBox();
            this.CheckedAccountsTextBox = new Krypton.Toolkit.KryptonTextBox();
            this.StatusTextBox = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            this.NoProxyRadioButton = new Krypton.Toolkit.KryptonRadioButton();
            this.HTTPProxyRadioButton = new Krypton.Toolkit.KryptonRadioButton();
            this.Socks5RadioButton = new Krypton.Toolkit.KryptonRadioButton();
            this.DelayUpDown = new Krypton.Toolkit.KryptonNumericUpDown();
            this.ThreadsUpDown = new Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonLabel9 = new Krypton.Toolkit.KryptonLabel();
            this.ActiveTopMostCheckBox = new Krypton.Toolkit.KryptonCheckBox();
            this.label1 = new Krypton.Toolkit.KryptonLabel();
            this.ProxyCountTextBox = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel10 = new Krypton.Toolkit.KryptonLabel();
            this.SkipUpDown = new Krypton.Toolkit.KryptonNumericUpDown();
            this.SuspendLayout();
            // 
            // LoadProxyBtn
            // 
            this.LoadProxyBtn.CornerRoundingRadius = -1F;
            this.LoadProxyBtn.Location = new System.Drawing.Point(287, 64);
            this.LoadProxyBtn.Name = "LoadProxyBtn";
            this.LoadProxyBtn.Size = new System.Drawing.Size(112, 34);
            this.LoadProxyBtn.StateCommon.Back.Color1 = System.Drawing.Color.Navy;
            this.LoadProxyBtn.StateCommon.Back.Color2 = System.Drawing.Color.Navy;
            this.LoadProxyBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LoadProxyBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoadProxyBtn.TabIndex = 0;
            this.LoadProxyBtn.Values.Text = "Load Proxy";
            // 
            // LoadDataBtn
            // 
            this.LoadDataBtn.CornerRoundingRadius = -1F;
            this.LoadDataBtn.Location = new System.Drawing.Point(287, 10);
            this.LoadDataBtn.Name = "LoadDataBtn";
            this.LoadDataBtn.Size = new System.Drawing.Size(112, 34);
            this.LoadDataBtn.StateCommon.Back.Color1 = System.Drawing.Color.Navy;
            this.LoadDataBtn.StateCommon.Back.Color2 = System.Drawing.Color.Navy;
            this.LoadDataBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LoadDataBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoadDataBtn.TabIndex = 1;
            this.LoadDataBtn.Values.Text = "Load Data";
            // 
            // StartBtn
            // 
            this.StartBtn.CornerRoundingRadius = -1F;
            this.StartBtn.Location = new System.Drawing.Point(287, 117);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(112, 34);
            this.StartBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.StartBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.StartBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.StartBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartBtn.TabIndex = 2;
            this.StartBtn.Values.Text = "Start";
            // 
            // StopBtn
            // 
            this.StopBtn.CornerRoundingRadius = -1F;
            this.StopBtn.Enabled = false;
            this.StopBtn.Location = new System.Drawing.Point(287, 172);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(112, 34);
            this.StopBtn.StateCommon.Back.Color1 = System.Drawing.Color.Maroon;
            this.StopBtn.StateCommon.Back.Color2 = System.Drawing.Color.Maroon;
            this.StopBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.StopBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StopBtn.TabIndex = 3;
            this.StopBtn.Values.Text = "Stop";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(15, 13);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(98, 20);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel1.TabIndex = 4;
            this.kryptonLabel1.Values.Text = "Tổng accounts:";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(15, 50);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(82, 20);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel2.TabIndex = 5;
            this.kryptonLabel2.Values.Text = "Thành công:";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(15, 87);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(61, 20);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel3.TabIndex = 6;
            this.kryptonLabel3.Values.Text = "Thất bại:";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(15, 124);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(81, 20);
            this.kryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel4.TabIndex = 7;
            this.kryptonLabel4.Values.Text = "Đã kiểm tra:";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(15, 197);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(74, 20);
            this.kryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel5.TabIndex = 8;
            this.kryptonLabel5.Values.Text = "Trạng thái:";
            // 
            // TotalAccountsTextBox
            // 
            this.TotalAccountsTextBox.Location = new System.Drawing.Point(123, 10);
            this.TotalAccountsTextBox.Name = "TotalAccountsTextBox";
            this.TotalAccountsTextBox.ReadOnly = true;
            this.TotalAccountsTextBox.Size = new System.Drawing.Size(139, 23);
            this.TotalAccountsTextBox.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TotalAccountsTextBox.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.TotalAccountsTextBox.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalAccountsTextBox.TabIndex = 9;
            this.TotalAccountsTextBox.Text = "0";
            this.TotalAccountsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SuccessAccountsTextBox
            // 
            this.SuccessAccountsTextBox.Location = new System.Drawing.Point(123, 47);
            this.SuccessAccountsTextBox.Name = "SuccessAccountsTextBox";
            this.SuccessAccountsTextBox.ReadOnly = true;
            this.SuccessAccountsTextBox.Size = new System.Drawing.Size(139, 23);
            this.SuccessAccountsTextBox.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SuccessAccountsTextBox.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.SuccessAccountsTextBox.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SuccessAccountsTextBox.TabIndex = 10;
            this.SuccessAccountsTextBox.Text = "0";
            this.SuccessAccountsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FailedAccountsTextBox
            // 
            this.FailedAccountsTextBox.Location = new System.Drawing.Point(123, 84);
            this.FailedAccountsTextBox.Name = "FailedAccountsTextBox";
            this.FailedAccountsTextBox.ReadOnly = true;
            this.FailedAccountsTextBox.Size = new System.Drawing.Size(139, 23);
            this.FailedAccountsTextBox.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.FailedAccountsTextBox.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.FailedAccountsTextBox.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FailedAccountsTextBox.TabIndex = 11;
            this.FailedAccountsTextBox.Text = "0";
            this.FailedAccountsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CheckedAccountsTextBox
            // 
            this.CheckedAccountsTextBox.Location = new System.Drawing.Point(123, 121);
            this.CheckedAccountsTextBox.Name = "CheckedAccountsTextBox";
            this.CheckedAccountsTextBox.ReadOnly = true;
            this.CheckedAccountsTextBox.Size = new System.Drawing.Size(139, 23);
            this.CheckedAccountsTextBox.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CheckedAccountsTextBox.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.CheckedAccountsTextBox.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CheckedAccountsTextBox.TabIndex = 12;
            this.CheckedAccountsTextBox.Text = "0";
            this.CheckedAccountsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.Location = new System.Drawing.Point(123, 194);
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.ReadOnly = true;
            this.StatusTextBox.Size = new System.Drawing.Size(139, 23);
            this.StatusTextBox.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.StatusTextBox.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.StatusTextBox.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StatusTextBox.TabIndex = 13;
            this.StatusTextBox.Text = "Chưa bắt đầu";
            this.StatusTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(287, 234);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(46, 20);
            this.kryptonLabel6.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel6.TabIndex = 14;
            this.kryptonLabel6.Values.Text = "Delay:";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(15, 278);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(65, 20);
            this.kryptonLabel7.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel7.TabIndex = 15;
            this.kryptonLabel7.Values.Text = "Số luồng:";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(15, 320);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(47, 20);
            this.kryptonLabel8.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonLabel8.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel8.TabIndex = 16;
            this.kryptonLabel8.Values.Text = "Proxy:";
            // 
            // NoProxyRadioButton
            // 
            this.NoProxyRadioButton.Checked = true;
            this.NoProxyRadioButton.Location = new System.Drawing.Point(123, 320);
            this.NoProxyRadioButton.Name = "NoProxyRadioButton";
            this.NoProxyRadioButton.Size = new System.Drawing.Size(77, 20);
            this.NoProxyRadioButton.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NoProxyRadioButton.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NoProxyRadioButton.TabIndex = 17;
            this.NoProxyRadioButton.Values.Text = "Proxyless";
            // 
            // HTTPProxyRadioButton
            // 
            this.HTTPProxyRadioButton.Location = new System.Drawing.Point(123, 346);
            this.HTTPProxyRadioButton.Name = "HTTPProxyRadioButton";
            this.HTTPProxyRadioButton.Size = new System.Drawing.Size(54, 20);
            this.HTTPProxyRadioButton.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.HTTPProxyRadioButton.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HTTPProxyRadioButton.TabIndex = 18;
            this.HTTPProxyRadioButton.Values.Text = "HTTP";
            // 
            // Socks5RadioButton
            // 
            this.Socks5RadioButton.Location = new System.Drawing.Point(123, 376);
            this.Socks5RadioButton.Name = "Socks5RadioButton";
            this.Socks5RadioButton.Size = new System.Drawing.Size(62, 20);
            this.Socks5RadioButton.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Socks5RadioButton.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Socks5RadioButton.TabIndex = 19;
            this.Socks5RadioButton.Values.Text = "Socks5";
            // 
            // DelayUpDown
            // 
            this.DelayUpDown.Location = new System.Drawing.Point(339, 234);
            this.DelayUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.DelayUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DelayUpDown.Name = "DelayUpDown";
            this.DelayUpDown.Size = new System.Drawing.Size(60, 22);
            this.DelayUpDown.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.DelayUpDown.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.DelayUpDown.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DelayUpDown.TabIndex = 20;
            this.DelayUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // ThreadsUpDown
            // 
            this.ThreadsUpDown.Location = new System.Drawing.Point(123, 276);
            this.ThreadsUpDown.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.ThreadsUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ThreadsUpDown.Name = "ThreadsUpDown";
            this.ThreadsUpDown.Size = new System.Drawing.Size(139, 22);
            this.ThreadsUpDown.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ThreadsUpDown.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.ThreadsUpDown.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ThreadsUpDown.TabIndex = 21;
            this.ThreadsUpDown.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(15, 406);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(69, 20);
            this.kryptonLabel9.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonLabel9.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel9.TabIndex = 22;
            this.kryptonLabel9.Values.Text = "Top most:";
            // 
            // ActiveTopMostCheckBox
            // 
            this.ActiveTopMostCheckBox.Checked = true;
            this.ActiveTopMostCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ActiveTopMostCheckBox.Location = new System.Drawing.Point(123, 406);
            this.ActiveTopMostCheckBox.Name = "ActiveTopMostCheckBox";
            this.ActiveTopMostCheckBox.Size = new System.Drawing.Size(60, 20);
            this.ActiveTopMostCheckBox.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ActiveTopMostCheckBox.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ActiveTopMostCheckBox.TabIndex = 23;
            this.ActiveTopMostCheckBox.Values.Text = "Active";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.TabIndex = 24;
            this.label1.Values.Text = "Số proxy:";
            // 
            // ProxyCountTextBox
            // 
            this.ProxyCountTextBox.Location = new System.Drawing.Point(123, 157);
            this.ProxyCountTextBox.Name = "ProxyCountTextBox";
            this.ProxyCountTextBox.ReadOnly = true;
            this.ProxyCountTextBox.Size = new System.Drawing.Size(139, 23);
            this.ProxyCountTextBox.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ProxyCountTextBox.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.ProxyCountTextBox.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProxyCountTextBox.TabIndex = 25;
            this.ProxyCountTextBox.Text = "0";
            this.ProxyCountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(15, 236);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(39, 20);
            this.kryptonLabel10.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonLabel10.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel10.TabIndex = 26;
            this.kryptonLabel10.Values.Text = "Skip:";
            // 
            // SkipUpDown
            // 
            this.SkipUpDown.Location = new System.Drawing.Point(123, 234);
            this.SkipUpDown.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.SkipUpDown.Name = "SkipUpDown";
            this.SkipUpDown.Size = new System.Drawing.Size(139, 22);
            this.SkipUpDown.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SkipUpDown.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.SkipUpDown.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SkipUpDown.TabIndex = 27;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(419, 446);
            this.Controls.Add(this.SkipUpDown);
            this.Controls.Add(this.kryptonLabel10);
            this.Controls.Add(this.ProxyCountTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ActiveTopMostCheckBox);
            this.Controls.Add(this.kryptonLabel9);
            this.Controls.Add(this.ThreadsUpDown);
            this.Controls.Add(this.DelayUpDown);
            this.Controls.Add(this.Socks5RadioButton);
            this.Controls.Add(this.HTTPProxyRadioButton);
            this.Controls.Add(this.NoProxyRadioButton);
            this.Controls.Add(this.kryptonLabel8);
            this.Controls.Add(this.kryptonLabel7);
            this.Controls.Add(this.kryptonLabel6);
            this.Controls.Add(this.StatusTextBox);
            this.Controls.Add(this.CheckedAccountsTextBox);
            this.Controls.Add(this.FailedAccountsTextBox);
            this.Controls.Add(this.SuccessAccountsTextBox);
            this.Controls.Add(this.TotalAccountsTextBox);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.LoadDataBtn);
            this.Controls.Add(this.LoadProxyBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(435, 485);
            this.MinimumSize = new System.Drawing.Size(435, 485);
            this.Name = "FrmMain";
            this.Text = "Oracle Scan - Tele: @lukaxsx";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonButton LoadProxyBtn;
        private Krypton.Toolkit.KryptonButton LoadDataBtn;
        private Krypton.Toolkit.KryptonButton StartBtn;
        private Krypton.Toolkit.KryptonButton StopBtn;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonTextBox TotalAccountsTextBox;
        private Krypton.Toolkit.KryptonTextBox SuccessAccountsTextBox;
        private Krypton.Toolkit.KryptonTextBox FailedAccountsTextBox;
        private Krypton.Toolkit.KryptonTextBox CheckedAccountsTextBox;
        private Krypton.Toolkit.KryptonTextBox StatusTextBox;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private Krypton.Toolkit.KryptonRadioButton NoProxyRadioButton;
        private Krypton.Toolkit.KryptonRadioButton HTTPProxyRadioButton;
        private Krypton.Toolkit.KryptonRadioButton Socks5RadioButton;
        private Krypton.Toolkit.KryptonNumericUpDown DelayUpDown;
        private Krypton.Toolkit.KryptonNumericUpDown ThreadsUpDown;
        private Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private Krypton.Toolkit.KryptonCheckBox ActiveTopMostCheckBox;
        private Krypton.Toolkit.KryptonLabel label1;
        private Krypton.Toolkit.KryptonTextBox ProxyCountTextBox;
        private Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private Krypton.Toolkit.KryptonNumericUpDown SkipUpDown;
    }
}