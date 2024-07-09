namespace WireShare
{
    partial class Serial
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            MetroSet_UI.Controls.MetroSetLabel metroSetLabel4;
            this.buttonConnect = new MetroSet_UI.Controls.MetroSetButton();
            this.ButtonDisconnect = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.BaudRate = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel5 = new MetroSet_UI.Controls.MetroSetLabel();
            this.comboboxPorts = new MetroSet_UI.Controls.MetroSetComboBox();
            this.comboboxstopbits = new MetroSet_UI.Controls.MetroSetComboBox();
            this.comboboxparity = new MetroSet_UI.Controls.MetroSetComboBox();
            this.comboboxbaud = new MetroSet_UI.Controls.MetroSetComboBox();
            this.comboboxdatabits = new MetroSet_UI.Controls.MetroSetComboBox();
            this.textBoxReceive = new System.Windows.Forms.TextBox();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.buttonsend = new MetroSet_UI.Controls.MetroSetButton();
            metroSetLabel4 = new MetroSet_UI.Controls.MetroSetLabel();
            this.SuspendLayout();
            // 
            // metroSetLabel4
            // 
            metroSetLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            metroSetLabel4.IsDerivedStyle = true;
            metroSetLabel4.Location = new System.Drawing.Point(89, 228);
            metroSetLabel4.Name = "metroSetLabel4";
            metroSetLabel4.Size = new System.Drawing.Size(125, 29);
            metroSetLabel4.Style = MetroSet_UI.Enums.Style.Dark;
            metroSetLabel4.StyleManager = null;
            metroSetLabel4.TabIndex = 5;
            metroSetLabel4.Text = "DataBits:";
            metroSetLabel4.ThemeAuthor = "Narwin";
            metroSetLabel4.ThemeName = "MetroDark";
            // 
            // buttonConnect
            // 
            this.buttonConnect.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.buttonConnect.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.buttonConnect.DisabledForeColor = System.Drawing.Color.Gray;
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonConnect.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.buttonConnect.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.buttonConnect.HoverTextColor = System.Drawing.Color.White;
            this.buttonConnect.IsDerivedStyle = true;
            this.buttonConnect.Location = new System.Drawing.Point(107, 317);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.buttonConnect.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.buttonConnect.NormalTextColor = System.Drawing.Color.White;
            this.buttonConnect.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.buttonConnect.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.buttonConnect.PressTextColor = System.Drawing.Color.White;
            this.buttonConnect.Size = new System.Drawing.Size(94, 29);
            this.buttonConnect.Style = MetroSet_UI.Enums.Style.Light;
            this.buttonConnect.StyleManager = null;
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.ThemeAuthor = "Narwin";
            this.buttonConnect.ThemeName = "MetroLite";
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // ButtonDisconnect
            // 
            this.ButtonDisconnect.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ButtonDisconnect.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ButtonDisconnect.DisabledForeColor = System.Drawing.Color.Gray;
            this.ButtonDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonDisconnect.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.ButtonDisconnect.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.ButtonDisconnect.HoverTextColor = System.Drawing.Color.White;
            this.ButtonDisconnect.IsDerivedStyle = true;
            this.ButtonDisconnect.Location = new System.Drawing.Point(227, 317);
            this.ButtonDisconnect.Name = "ButtonDisconnect";
            this.ButtonDisconnect.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ButtonDisconnect.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ButtonDisconnect.NormalTextColor = System.Drawing.Color.White;
            this.ButtonDisconnect.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.ButtonDisconnect.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.ButtonDisconnect.PressTextColor = System.Drawing.Color.White;
            this.ButtonDisconnect.Size = new System.Drawing.Size(94, 29);
            this.ButtonDisconnect.Style = MetroSet_UI.Enums.Style.Light;
            this.ButtonDisconnect.StyleManager = null;
            this.ButtonDisconnect.TabIndex = 1;
            this.ButtonDisconnect.Text = "Disconnect";
            this.ButtonDisconnect.ThemeAuthor = "Narwin";
            this.ButtonDisconnect.ThemeName = "MetroLite";
            this.ButtonDisconnect.Click += new System.EventHandler(this.ButtonDisconnect_Click);
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(89, 62);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(125, 29);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 2;
            this.metroSetLabel1.Text = "Port:";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroDark";
            // 
            // BaudRate
            // 
            this.BaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BaudRate.IsDerivedStyle = true;
            this.BaudRate.Location = new System.Drawing.Point(89, 102);
            this.BaudRate.Name = "BaudRate";
            this.BaudRate.Size = new System.Drawing.Size(125, 29);
            this.BaudRate.Style = MetroSet_UI.Enums.Style.Dark;
            this.BaudRate.StyleManager = null;
            this.BaudRate.TabIndex = 3;
            this.BaudRate.Text = "BaudRate:";
            this.BaudRate.ThemeAuthor = "Narwin";
            this.BaudRate.ThemeName = "MetroDark";
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel3.IsDerivedStyle = true;
            this.metroSetLabel3.Location = new System.Drawing.Point(89, 184);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(125, 24);
            this.metroSetLabel3.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 4;
            this.metroSetLabel3.Text = "Stopbits";
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroDark";
            // 
            // metroSetLabel5
            // 
            this.metroSetLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel5.IsDerivedStyle = true;
            this.metroSetLabel5.Location = new System.Drawing.Point(89, 143);
            this.metroSetLabel5.Name = "metroSetLabel5";
            this.metroSetLabel5.Size = new System.Drawing.Size(125, 29);
            this.metroSetLabel5.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel5.StyleManager = null;
            this.metroSetLabel5.TabIndex = 6;
            this.metroSetLabel5.Text = "Parity:";
            this.metroSetLabel5.ThemeAuthor = "Narwin";
            this.metroSetLabel5.ThemeName = "MetroDark";
            // 
            // comboboxPorts
            // 
            this.comboboxPorts.AllowDrop = true;
            this.comboboxPorts.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.comboboxPorts.BackColor = System.Drawing.Color.Transparent;
            this.comboboxPorts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.comboboxPorts.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.comboboxPorts.CausesValidation = false;
            this.comboboxPorts.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.comboboxPorts.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.comboboxPorts.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.comboboxPorts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboboxPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboboxPorts.FormattingEnabled = true;
            this.comboboxPorts.IsDerivedStyle = true;
            this.comboboxPorts.ItemHeight = 20;
            this.comboboxPorts.Location = new System.Drawing.Point(220, 62);
            this.comboboxPorts.Name = "comboboxPorts";
            this.comboboxPorts.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.comboboxPorts.SelectedItemForeColor = System.Drawing.Color.White;
            this.comboboxPorts.Size = new System.Drawing.Size(151, 26);
            this.comboboxPorts.Style = MetroSet_UI.Enums.Style.Light;
            this.comboboxPorts.StyleManager = null;
            this.comboboxPorts.TabIndex = 7;
            this.comboboxPorts.ThemeAuthor = "Narwin";
            this.comboboxPorts.ThemeName = "MetroLite";
            // 
            // comboboxstopbits
            // 
            this.comboboxstopbits.AllowDrop = true;
            this.comboboxstopbits.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.comboboxstopbits.BackColor = System.Drawing.Color.Transparent;
            this.comboboxstopbits.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.comboboxstopbits.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.comboboxstopbits.CausesValidation = false;
            this.comboboxstopbits.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.comboboxstopbits.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.comboboxstopbits.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.comboboxstopbits.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboboxstopbits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxstopbits.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboboxstopbits.FormattingEnabled = true;
            this.comboboxstopbits.IsDerivedStyle = true;
            this.comboboxstopbits.ItemHeight = 20;
            this.comboboxstopbits.Location = new System.Drawing.Point(220, 184);
            this.comboboxstopbits.Name = "comboboxstopbits";
            this.comboboxstopbits.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.comboboxstopbits.SelectedItemForeColor = System.Drawing.Color.White;
            this.comboboxstopbits.Size = new System.Drawing.Size(151, 26);
            this.comboboxstopbits.Style = MetroSet_UI.Enums.Style.Light;
            this.comboboxstopbits.StyleManager = null;
            this.comboboxstopbits.TabIndex = 10;
            this.comboboxstopbits.ThemeAuthor = "Narwin";
            this.comboboxstopbits.ThemeName = "MetroLite";
            // 
            // comboboxparity
            // 
            this.comboboxparity.AllowDrop = true;
            this.comboboxparity.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.comboboxparity.BackColor = System.Drawing.Color.Transparent;
            this.comboboxparity.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.comboboxparity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.comboboxparity.CausesValidation = false;
            this.comboboxparity.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.comboboxparity.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.comboboxparity.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.comboboxparity.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboboxparity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxparity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboboxparity.FormattingEnabled = true;
            this.comboboxparity.IsDerivedStyle = true;
            this.comboboxparity.ItemHeight = 20;
            this.comboboxparity.Location = new System.Drawing.Point(220, 143);
            this.comboboxparity.Name = "comboboxparity";
            this.comboboxparity.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.comboboxparity.SelectedItemForeColor = System.Drawing.Color.White;
            this.comboboxparity.Size = new System.Drawing.Size(151, 26);
            this.comboboxparity.Style = MetroSet_UI.Enums.Style.Light;
            this.comboboxparity.StyleManager = null;
            this.comboboxparity.TabIndex = 11;
            this.comboboxparity.ThemeAuthor = "Narwin";
            this.comboboxparity.ThemeName = "MetroLite";
            // 
            // comboboxbaud
            // 
            this.comboboxbaud.AllowDrop = true;
            this.comboboxbaud.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.comboboxbaud.BackColor = System.Drawing.Color.Transparent;
            this.comboboxbaud.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.comboboxbaud.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.comboboxbaud.CausesValidation = false;
            this.comboboxbaud.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.comboboxbaud.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.comboboxbaud.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.comboboxbaud.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboboxbaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxbaud.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboboxbaud.FormattingEnabled = true;
            this.comboboxbaud.IsDerivedStyle = true;
            this.comboboxbaud.ItemHeight = 20;
            this.comboboxbaud.Location = new System.Drawing.Point(220, 102);
            this.comboboxbaud.Name = "comboboxbaud";
            this.comboboxbaud.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.comboboxbaud.SelectedItemForeColor = System.Drawing.Color.White;
            this.comboboxbaud.Size = new System.Drawing.Size(151, 26);
            this.comboboxbaud.Style = MetroSet_UI.Enums.Style.Light;
            this.comboboxbaud.StyleManager = null;
            this.comboboxbaud.TabIndex = 12;
            this.comboboxbaud.ThemeAuthor = "Narwin";
            this.comboboxbaud.ThemeName = "MetroLite";
            // 
            // comboboxdatabits
            // 
            this.comboboxdatabits.AllowDrop = true;
            this.comboboxdatabits.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.comboboxdatabits.BackColor = System.Drawing.Color.Transparent;
            this.comboboxdatabits.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.comboboxdatabits.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.comboboxdatabits.CausesValidation = false;
            this.comboboxdatabits.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.comboboxdatabits.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.comboboxdatabits.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.comboboxdatabits.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboboxdatabits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxdatabits.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboboxdatabits.FormattingEnabled = true;
            this.comboboxdatabits.IsDerivedStyle = true;
            this.comboboxdatabits.ItemHeight = 20;
            this.comboboxdatabits.Location = new System.Drawing.Point(220, 228);
            this.comboboxdatabits.Name = "comboboxdatabits";
            this.comboboxdatabits.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.comboboxdatabits.SelectedItemForeColor = System.Drawing.Color.White;
            this.comboboxdatabits.Size = new System.Drawing.Size(151, 26);
            this.comboboxdatabits.Style = MetroSet_UI.Enums.Style.Light;
            this.comboboxdatabits.StyleManager = null;
            this.comboboxdatabits.TabIndex = 13;
            this.comboboxdatabits.ThemeAuthor = "Narwin";
            this.comboboxdatabits.ThemeName = "MetroLite";
            // 
            // textBoxReceive
            // 
            this.textBoxReceive.Location = new System.Drawing.Point(496, 64);
            this.textBoxReceive.Multiline = true;
            this.textBoxReceive.Name = "textBoxReceive";
            this.textBoxReceive.Size = new System.Drawing.Size(274, 203);
            this.textBoxReceive.TabIndex = 14;
            this.textBoxReceive.TextChanged += new System.EventHandler(this.textBoxReceive_TextChanged);
            // 
            // textBoxSend
            // 
            this.textBoxSend.Location = new System.Drawing.Point(496, 301);
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(274, 27);
            this.textBoxSend.TabIndex = 15;
            // 
            // buttonsend
            // 
            this.buttonsend.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.buttonsend.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.buttonsend.DisabledForeColor = System.Drawing.Color.Gray;
            this.buttonsend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonsend.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.buttonsend.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.buttonsend.HoverTextColor = System.Drawing.Color.White;
            this.buttonsend.IsDerivedStyle = true;
            this.buttonsend.Location = new System.Drawing.Point(589, 344);
            this.buttonsend.Name = "buttonsend";
            this.buttonsend.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.buttonsend.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.buttonsend.NormalTextColor = System.Drawing.Color.White;
            this.buttonsend.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.buttonsend.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.buttonsend.PressTextColor = System.Drawing.Color.White;
            this.buttonsend.Size = new System.Drawing.Size(94, 29);
            this.buttonsend.Style = MetroSet_UI.Enums.Style.Light;
            this.buttonsend.StyleManager = null;
            this.buttonsend.TabIndex = 16;
            this.buttonsend.Text = "Send";
            this.buttonsend.ThemeAuthor = "Narwin";
            this.buttonsend.ThemeName = "MetroLite";
            this.buttonsend.Click += new System.EventHandler(this.buttonsend_Click);
            // 
            // Serial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.buttonsend);
            this.Controls.Add(this.textBoxSend);
            this.Controls.Add(this.textBoxReceive);
            this.Controls.Add(this.comboboxdatabits);
            this.Controls.Add(this.comboboxbaud);
            this.Controls.Add(this.comboboxparity);
            this.Controls.Add(this.comboboxstopbits);
            this.Controls.Add(this.comboboxPorts);
            this.Controls.Add(this.metroSetLabel5);
            this.Controls.Add(metroSetLabel4);
            this.Controls.Add(this.metroSetLabel3);
            this.Controls.Add(this.BaudRate);
            this.Controls.Add(this.metroSetLabel1);
            this.Controls.Add(this.ButtonDisconnect);
            this.Controls.Add(this.buttonConnect);
            this.Name = "Serial";
            this.Size = new System.Drawing.Size(886, 545);
            this.Load += new System.EventHandler(this.Serial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetButton buttonConnect;
        private MetroSet_UI.Controls.MetroSetButton ButtonDisconnect;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetLabel BaudRate;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel5;
        private MetroSet_UI.Controls.MetroSetComboBox comboboxPorts;
        private MetroSet_UI.Controls.MetroSetComboBox comboboxstopbits;
        private MetroSet_UI.Controls.MetroSetComboBox comboboxparity;
        private MetroSet_UI.Controls.MetroSetComboBox comboboxbaud;
        private MetroSet_UI.Controls.MetroSetComboBox comboboxdatabits;
        private TextBox textBoxReceive;
        private TextBox textBoxSend;
        private MetroSet_UI.Controls.MetroSetButton buttonsend;
    }
}
