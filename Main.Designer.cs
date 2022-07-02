
using System.Windows.Forms;
using DateConverter.Assets;

namespace DateConverter
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dtpTab2Date = new System.Windows.Forms.DateTimePicker();
            this.cboTab2SourceTimeZoneChooser = new System.Windows.Forms.ComboBox();
            this.dtpTab2Time = new System.Windows.Forms.DateTimePicker();
            this.txtTab2UTC = new System.Windows.Forms.TextBox();
            this.btnTab2ConvertDates = new System.Windows.Forms.Button();
            this.cboTab2TargetTimeZoneChooser = new System.Windows.Forms.ComboBox();
            this.txtTab2TargetDate = new System.Windows.Forms.TextBox();
            this.txtTab2TargetEpoch = new System.Windows.Forms.TextBox();
            this.txtTab2LocalTicks = new System.Windows.Forms.TextBox();
            this.txtTab2UtcTicks = new System.Windows.Forms.TextBox();
            this.tabUtils = new System.Windows.Forms.TabControl();
            this.pgeMsConvert = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblForTargetTimezone = new System.Windows.Forms.Label();
            this.txtTab0MillisecondsInput = new System.Windows.Forms.TextBox();
            this.txtTab0UTCTickFromMs = new System.Windows.Forms.TextBox();
            this.txtTab0LocalDateTime = new System.Windows.Forms.TextBox();
            this.btnTab0Convert = new System.Windows.Forms.Button();
            this.txtTab0LocalTickFromMs = new System.Windows.Forms.TextBox();
            this.txtTab0UTCDateTime = new System.Windows.Forms.TextBox();
            this.cboTab0TimeZone = new System.Windows.Forms.ComboBox();
            this.pgeDateConvert = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpTab1Time = new System.Windows.Forms.DateTimePicker();
            this.txtTab1Milliseconds = new System.Windows.Forms.TextBox();
            this.txtTab1UTCTicks = new System.Windows.Forms.TextBox();
            this.txtTab1LocalDateTime = new System.Windows.Forms.TextBox();
            this.btnTab1Convert = new System.Windows.Forms.Button();
            this.cboTab1TimeZones = new System.Windows.Forms.ComboBox();
            this.txtTab1LocalTicks = new System.Windows.Forms.TextBox();
            this.txtTab1UTCDateTime = new System.Windows.Forms.TextBox();
            this.dtpTab1Date = new System.Windows.Forms.DateTimePicker();
            this.pgeZoneConvert = new System.Windows.Forms.TabPage();
            this.txtTargetOffset = new System.Windows.Forms.TextBox();
            this.txtSourceOffset = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTab2SourceTicks = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMillisecondsFromUtc = new System.Windows.Forms.Label();
            this.lblUtcDateAndTime = new System.Windows.Forms.Label();
            this.lblTargetDateAndTime = new System.Windows.Forms.Label();
            this.lblTargetTimeZone = new System.Windows.Forms.Label();
            this.lblSourceTimeZone = new System.Windows.Forms.Label();
            this.lblInputDate = new System.Windows.Forms.Label();
            this.pgeTicksConvert = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtTab3Ticks = new System.Windows.Forms.TextBox();
            this.txtTab3DateTime = new System.Windows.Forms.TextBox();
            this.btnTab3Convert = new System.Windows.Forms.Button();
            this.tabIcons = new System.Windows.Forms.ImageList(this.components);
            this.tabUtils.SuspendLayout();
            this.pgeMsConvert.SuspendLayout();
            this.pgeDateConvert.SuspendLayout();
            this.pgeZoneConvert.SuspendLayout();
            this.pgeTicksConvert.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpTab2Date
            // 
            this.dtpTab2Date.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpTab2Date.Location = new System.Drawing.Point(221, 38);
            this.dtpTab2Date.Name = "dtpTab2Date";
            this.dtpTab2Date.Size = new System.Drawing.Size(422, 39);
            this.dtpTab2Date.TabIndex = 1;
            // 
            // cboTab2SourceTimeZoneChooser
            // 
            this.cboTab2SourceTimeZoneChooser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboTab2SourceTimeZoneChooser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTab2SourceTimeZoneChooser.DisplayMember = "Name";
            this.cboTab2SourceTimeZoneChooser.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboTab2SourceTimeZoneChooser.FormattingEnabled = true;
            this.cboTab2SourceTimeZoneChooser.Location = new System.Drawing.Point(221, 112);
            this.cboTab2SourceTimeZoneChooser.Name = "cboTab2SourceTimeZoneChooser";
            this.cboTab2SourceTimeZoneChooser.Size = new System.Drawing.Size(422, 40);
            this.cboTab2SourceTimeZoneChooser.TabIndex = 2;
            this.cboTab2SourceTimeZoneChooser.ValueMember = "Id";
            this.cboTab2SourceTimeZoneChooser.SelectedIndexChanged += new System.EventHandler(this.cboTab2SourceTimeZoneChooser_SelectedIndexChanged);
            // 
            // dtpTab2Time
            // 
            this.dtpTab2Time.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpTab2Time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTab2Time.Location = new System.Drawing.Point(649, 38);
            this.dtpTab2Time.Name = "dtpTab2Time";
            this.dtpTab2Time.ShowUpDown = true;
            this.dtpTab2Time.Size = new System.Drawing.Size(156, 39);
            this.dtpTab2Time.TabIndex = 3;
            // 
            // txtTab2UTC
            // 
            this.txtTab2UTC.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTab2UTC.Location = new System.Drawing.Point(221, 258);
            this.txtTab2UTC.Name = "txtTab2UTC";
            this.txtTab2UTC.Size = new System.Drawing.Size(422, 39);
            this.txtTab2UTC.TabIndex = 6;
            // 
            // btnTab2ConvertDates
            // 
            this.btnTab2ConvertDates.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTab2ConvertDates.Location = new System.Drawing.Point(869, 303);
            this.btnTab2ConvertDates.Name = "btnTab2ConvertDates";
            this.btnTab2ConvertDates.Size = new System.Drawing.Size(113, 45);
            this.btnTab2ConvertDates.TabIndex = 7;
            this.btnTab2ConvertDates.Text = "&Convert";
            this.btnTab2ConvertDates.UseVisualStyleBackColor = true;
            this.btnTab2ConvertDates.Click += new System.EventHandler(this.btnTab2ConvertDates_Click);
            // 
            // cboTab2TargetTimeZoneChooser
            // 
            this.cboTab2TargetTimeZoneChooser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboTab2TargetTimeZoneChooser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTab2TargetTimeZoneChooser.DisplayMember = "Name";
            this.cboTab2TargetTimeZoneChooser.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboTab2TargetTimeZoneChooser.FormattingEnabled = true;
            this.cboTab2TargetTimeZoneChooser.Location = new System.Drawing.Point(221, 161);
            this.cboTab2TargetTimeZoneChooser.Name = "cboTab2TargetTimeZoneChooser";
            this.cboTab2TargetTimeZoneChooser.Size = new System.Drawing.Size(422, 40);
            this.cboTab2TargetTimeZoneChooser.TabIndex = 8;
            this.cboTab2TargetTimeZoneChooser.ValueMember = "Id";
            this.cboTab2TargetTimeZoneChooser.SelectedIndexChanged += new System.EventHandler(this.cboTab2TargetTimeZoneChooser_SelectedIndexChanged);
            // 
            // txtTab2TargetDate
            // 
            this.txtTab2TargetDate.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTab2TargetDate.Location = new System.Drawing.Point(221, 210);
            this.txtTab2TargetDate.Name = "txtTab2TargetDate";
            this.txtTab2TargetDate.Size = new System.Drawing.Size(422, 39);
            this.txtTab2TargetDate.TabIndex = 9;
            // 
            // txtTab2TargetEpoch
            // 
            this.txtTab2TargetEpoch.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTab2TargetEpoch.Location = new System.Drawing.Point(221, 306);
            this.txtTab2TargetEpoch.Name = "txtTab2TargetEpoch";
            this.txtTab2TargetEpoch.Size = new System.Drawing.Size(422, 39);
            this.txtTab2TargetEpoch.TabIndex = 10;
            // 
            // txtTab2LocalTicks
            // 
            this.txtTab2LocalTicks.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTab2LocalTicks.Location = new System.Drawing.Point(869, 210);
            this.txtTab2LocalTicks.Name = "txtTab2LocalTicks";
            this.txtTab2LocalTicks.Size = new System.Drawing.Size(294, 39);
            this.txtTab2LocalTicks.TabIndex = 11;
            // 
            // txtTab2UtcTicks
            // 
            this.txtTab2UtcTicks.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTab2UtcTicks.Location = new System.Drawing.Point(869, 258);
            this.txtTab2UtcTicks.Name = "txtTab2UtcTicks";
            this.txtTab2UtcTicks.Size = new System.Drawing.Size(294, 39);
            this.txtTab2UtcTicks.TabIndex = 12;
            // 
            // tabUtils
            // 
            this.tabUtils.Controls.Add(this.pgeMsConvert);
            this.tabUtils.Controls.Add(this.pgeDateConvert);
            this.tabUtils.Controls.Add(this.pgeZoneConvert);
            this.tabUtils.Controls.Add(this.pgeTicksConvert);
            this.tabUtils.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabUtils.ImageList = this.tabIcons;
            this.tabUtils.Location = new System.Drawing.Point(22, 40);
            this.tabUtils.Name = "tabUtils";
            this.tabUtils.SelectedIndex = 0;
            this.tabUtils.Size = new System.Drawing.Size(1179, 410);
            this.tabUtils.TabIndex = 13;
            // 
            // pgeMsConvert
            // 
            this.pgeMsConvert.Controls.Add(this.label3);
            this.pgeMsConvert.Controls.Add(this.label4);
            this.pgeMsConvert.Controls.Add(this.label5);
            this.pgeMsConvert.Controls.Add(this.label6);
            this.pgeMsConvert.Controls.Add(this.label7);
            this.pgeMsConvert.Controls.Add(this.lblForTargetTimezone);
            this.pgeMsConvert.Controls.Add(this.txtTab0MillisecondsInput);
            this.pgeMsConvert.Controls.Add(this.txtTab0UTCTickFromMs);
            this.pgeMsConvert.Controls.Add(this.txtTab0LocalDateTime);
            this.pgeMsConvert.Controls.Add(this.btnTab0Convert);
            this.pgeMsConvert.Controls.Add(this.txtTab0LocalTickFromMs);
            this.pgeMsConvert.Controls.Add(this.txtTab0UTCDateTime);
            this.pgeMsConvert.Controls.Add(this.cboTab0TimeZone);
            this.pgeMsConvert.Location = new System.Drawing.Point(4, 41);
            this.pgeMsConvert.Name = "pgeMsConvert";
            this.pgeMsConvert.Padding = new System.Windows.Forms.Padding(3);
            this.pgeMsConvert.Size = new System.Drawing.Size(1171, 365);
            this.pgeMsConvert.TabIndex = 1;
            this.pgeMsConvert.Text = "Convert From Milliseconds";
            this.pgeMsConvert.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(675, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 32);
            this.label3.TabIndex = 38;
            this.label3.Text = "UTC Ticks:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(653, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 32);
            this.label4.TabIndex = 37;
            this.label4.Text = "Target Ticks:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(63, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 32);
            this.label5.TabIndex = 36;
            this.label5.Text = "Milliseconds:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(35, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 32);
            this.label6.TabIndex = 35;
            this.label6.Text = "UTC Date Time:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(13, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 32);
            this.label7.TabIndex = 34;
            this.label7.Text = "Target Date Time:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblForTargetTimezone
            // 
            this.lblForTargetTimezone.AutoSize = true;
            this.lblForTargetTimezone.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblForTargetTimezone.Location = new System.Drawing.Point(18, 119);
            this.lblForTargetTimezone.Name = "lblForTargetTimezone";
            this.lblForTargetTimezone.Size = new System.Drawing.Size(196, 32);
            this.lblForTargetTimezone.TabIndex = 32;
            this.lblForTargetTimezone.Text = "Target Timezone:";
            this.lblForTargetTimezone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTab0MillisecondsInput
            // 
            this.txtTab0MillisecondsInput.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTab0MillisecondsInput.Location = new System.Drawing.Point(220, 18);
            this.txtTab0MillisecondsInput.Name = "txtTab0MillisecondsInput";
            this.txtTab0MillisecondsInput.Size = new System.Drawing.Size(422, 39);
            this.txtTab0MillisecondsInput.TabIndex = 0;
            // 
            // txtTab0UTCTickFromMs
            // 
            this.txtTab0UTCTickFromMs.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTab0UTCTickFromMs.Location = new System.Drawing.Point(799, 219);
            this.txtTab0UTCTickFromMs.Name = "txtTab0UTCTickFromMs";
            this.txtTab0UTCTickFromMs.Size = new System.Drawing.Size(294, 39);
            this.txtTab0UTCTickFromMs.TabIndex = 30;
            // 
            // txtTab0LocalDateTime
            // 
            this.txtTab0LocalDateTime.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTab0LocalDateTime.Location = new System.Drawing.Point(220, 167);
            this.txtTab0LocalDateTime.Name = "txtTab0LocalDateTime";
            this.txtTab0LocalDateTime.Size = new System.Drawing.Size(422, 39);
            this.txtTab0LocalDateTime.TabIndex = 27;
            // 
            // btnTab0Convert
            // 
            this.btnTab0Convert.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTab0Convert.Location = new System.Drawing.Point(799, 283);
            this.btnTab0Convert.Name = "btnTab0Convert";
            this.btnTab0Convert.Size = new System.Drawing.Size(113, 45);
            this.btnTab0Convert.TabIndex = 25;
            this.btnTab0Convert.Text = "&Convert";
            this.btnTab0Convert.UseVisualStyleBackColor = true;
            this.btnTab0Convert.Click += new System.EventHandler(this.btnTab0Convert_Click);
            // 
            // txtTab0LocalTickFromMs
            // 
            this.txtTab0LocalTickFromMs.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTab0LocalTickFromMs.Location = new System.Drawing.Point(799, 170);
            this.txtTab0LocalTickFromMs.Name = "txtTab0LocalTickFromMs";
            this.txtTab0LocalTickFromMs.Size = new System.Drawing.Size(294, 39);
            this.txtTab0LocalTickFromMs.TabIndex = 29;
            // 
            // txtTab0UTCDateTime
            // 
            this.txtTab0UTCDateTime.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTab0UTCDateTime.Location = new System.Drawing.Point(220, 215);
            this.txtTab0UTCDateTime.Name = "txtTab0UTCDateTime";
            this.txtTab0UTCDateTime.Size = new System.Drawing.Size(422, 39);
            this.txtTab0UTCDateTime.TabIndex = 24;
            // 
            // cboTab0TimeZone
            // 
            this.cboTab0TimeZone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboTab0TimeZone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTab0TimeZone.DisplayMember = "Name";
            this.cboTab0TimeZone.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboTab0TimeZone.FormattingEnabled = true;
            this.cboTab0TimeZone.Location = new System.Drawing.Point(220, 115);
            this.cboTab0TimeZone.Name = "cboTab0TimeZone";
            this.cboTab0TimeZone.Size = new System.Drawing.Size(422, 40);
            this.cboTab0TimeZone.TabIndex = 22;
            this.cboTab0TimeZone.ValueMember = "Id";
            // 
            // pgeDateConvert
            // 
            this.pgeDateConvert.Controls.Add(this.label8);
            this.pgeDateConvert.Controls.Add(this.label9);
            this.pgeDateConvert.Controls.Add(this.label10);
            this.pgeDateConvert.Controls.Add(this.label11);
            this.pgeDateConvert.Controls.Add(this.label12);
            this.pgeDateConvert.Controls.Add(this.label13);
            this.pgeDateConvert.Controls.Add(this.label15);
            this.pgeDateConvert.Controls.Add(this.dtpTab1Time);
            this.pgeDateConvert.Controls.Add(this.txtTab1Milliseconds);
            this.pgeDateConvert.Controls.Add(this.txtTab1UTCTicks);
            this.pgeDateConvert.Controls.Add(this.txtTab1LocalDateTime);
            this.pgeDateConvert.Controls.Add(this.btnTab1Convert);
            this.pgeDateConvert.Controls.Add(this.cboTab1TimeZones);
            this.pgeDateConvert.Controls.Add(this.txtTab1LocalTicks);
            this.pgeDateConvert.Controls.Add(this.txtTab1UTCDateTime);
            this.pgeDateConvert.Controls.Add(this.dtpTab1Date);
            this.pgeDateConvert.Location = new System.Drawing.Point(4, 41);
            this.pgeDateConvert.Name = "pgeDateConvert";
            this.pgeDateConvert.Size = new System.Drawing.Size(1171, 365);
            this.pgeDateConvert.TabIndex = 3;
            this.pgeDateConvert.Text = "Convert from Date";
            this.pgeDateConvert.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(744, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 32);
            this.label8.TabIndex = 38;
            this.label8.Text = "UTC Ticks:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(722, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 32);
            this.label9.TabIndex = 37;
            this.label9.Text = "Target Ticks:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(65, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 32);
            this.label10.TabIndex = 36;
            this.label10.Text = "Milliseconds:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(37, 214);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 32);
            this.label11.TabIndex = 35;
            this.label11.Text = "UTC Date Time:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(87, 166);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 32);
            this.label12.TabIndex = 34;
            this.label12.Text = "Date Time:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(89, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 32);
            this.label13.TabIndex = 33;
            this.label13.Text = "TimeZone:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(39, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(177, 64);
            this.label15.TabIndex = 31;
            this.label15.Text = "Select a Source\r\nDate and Time:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpTab1Time
            // 
            this.dtpTab1Time.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpTab1Time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTab1Time.Location = new System.Drawing.Point(648, 38);
            this.dtpTab1Time.Name = "dtpTab1Time";
            this.dtpTab1Time.ShowUpDown = true;
            this.dtpTab1Time.Size = new System.Drawing.Size(156, 39);
            this.dtpTab1Time.TabIndex = 23;
            // 
            // txtTab1Milliseconds
            // 
            this.txtTab1Milliseconds.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTab1Milliseconds.Location = new System.Drawing.Point(220, 259);
            this.txtTab1Milliseconds.Name = "txtTab1Milliseconds";
            this.txtTab1Milliseconds.Size = new System.Drawing.Size(422, 39);
            this.txtTab1Milliseconds.TabIndex = 28;
            // 
            // txtTab1UTCTicks
            // 
            this.txtTab1UTCTicks.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTab1UTCTicks.Location = new System.Drawing.Point(868, 259);
            this.txtTab1UTCTicks.Name = "txtTab1UTCTicks";
            this.txtTab1UTCTicks.Size = new System.Drawing.Size(294, 39);
            this.txtTab1UTCTicks.TabIndex = 30;
            // 
            // txtTab1LocalDateTime
            // 
            this.txtTab1LocalDateTime.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTab1LocalDateTime.Location = new System.Drawing.Point(220, 163);
            this.txtTab1LocalDateTime.Name = "txtTab1LocalDateTime";
            this.txtTab1LocalDateTime.Size = new System.Drawing.Size(422, 39);
            this.txtTab1LocalDateTime.TabIndex = 27;
            // 
            // btnTab1Convert
            // 
            this.btnTab1Convert.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTab1Convert.Location = new System.Drawing.Point(868, 308);
            this.btnTab1Convert.Name = "btnTab1Convert";
            this.btnTab1Convert.Size = new System.Drawing.Size(113, 45);
            this.btnTab1Convert.TabIndex = 25;
            this.btnTab1Convert.Text = "&Convert";
            this.btnTab1Convert.UseVisualStyleBackColor = true;
            this.btnTab1Convert.Click += new System.EventHandler(this.btnTab1Convert_Click);
            // 
            // cboTab1TimeZones
            // 
            this.cboTab1TimeZones.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboTab1TimeZones.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTab1TimeZones.DisplayMember = "Name";
            this.cboTab1TimeZones.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboTab1TimeZones.FormattingEnabled = true;
            this.cboTab1TimeZones.Location = new System.Drawing.Point(220, 114);
            this.cboTab1TimeZones.Name = "cboTab1TimeZones";
            this.cboTab1TimeZones.Size = new System.Drawing.Size(422, 40);
            this.cboTab1TimeZones.TabIndex = 26;
            this.cboTab1TimeZones.ValueMember = "Id";
            // 
            // txtTab1LocalTicks
            // 
            this.txtTab1LocalTicks.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTab1LocalTicks.Location = new System.Drawing.Point(868, 211);
            this.txtTab1LocalTicks.Name = "txtTab1LocalTicks";
            this.txtTab1LocalTicks.Size = new System.Drawing.Size(294, 39);
            this.txtTab1LocalTicks.TabIndex = 29;
            // 
            // txtTab1UTCDateTime
            // 
            this.txtTab1UTCDateTime.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTab1UTCDateTime.Location = new System.Drawing.Point(220, 211);
            this.txtTab1UTCDateTime.Name = "txtTab1UTCDateTime";
            this.txtTab1UTCDateTime.Size = new System.Drawing.Size(422, 39);
            this.txtTab1UTCDateTime.TabIndex = 24;
            // 
            // dtpTab1Date
            // 
            this.dtpTab1Date.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpTab1Date.Location = new System.Drawing.Point(220, 38);
            this.dtpTab1Date.Name = "dtpTab1Date";
            this.dtpTab1Date.Size = new System.Drawing.Size(422, 39);
            this.dtpTab1Date.TabIndex = 21;
            // 
            // pgeZoneConvert
            // 
            this.pgeZoneConvert.Controls.Add(this.txtTargetOffset);
            this.pgeZoneConvert.Controls.Add(this.txtSourceOffset);
            this.pgeZoneConvert.Controls.Add(this.label14);
            this.pgeZoneConvert.Controls.Add(this.txtTab2SourceTicks);
            this.pgeZoneConvert.Controls.Add(this.label2);
            this.pgeZoneConvert.Controls.Add(this.label1);
            this.pgeZoneConvert.Controls.Add(this.lblMillisecondsFromUtc);
            this.pgeZoneConvert.Controls.Add(this.lblUtcDateAndTime);
            this.pgeZoneConvert.Controls.Add(this.lblTargetDateAndTime);
            this.pgeZoneConvert.Controls.Add(this.lblTargetTimeZone);
            this.pgeZoneConvert.Controls.Add(this.lblSourceTimeZone);
            this.pgeZoneConvert.Controls.Add(this.lblInputDate);
            this.pgeZoneConvert.Controls.Add(this.dtpTab2Time);
            this.pgeZoneConvert.Controls.Add(this.txtTab2TargetEpoch);
            this.pgeZoneConvert.Controls.Add(this.txtTab2UtcTicks);
            this.pgeZoneConvert.Controls.Add(this.txtTab2TargetDate);
            this.pgeZoneConvert.Controls.Add(this.btnTab2ConvertDates);
            this.pgeZoneConvert.Controls.Add(this.cboTab2TargetTimeZoneChooser);
            this.pgeZoneConvert.Controls.Add(this.txtTab2LocalTicks);
            this.pgeZoneConvert.Controls.Add(this.txtTab2UTC);
            this.pgeZoneConvert.Controls.Add(this.dtpTab2Date);
            this.pgeZoneConvert.Controls.Add(this.cboTab2SourceTimeZoneChooser);
            this.pgeZoneConvert.Location = new System.Drawing.Point(4, 41);
            this.pgeZoneConvert.Name = "pgeZoneConvert";
            this.pgeZoneConvert.Padding = new System.Windows.Forms.Padding(3);
            this.pgeZoneConvert.Size = new System.Drawing.Size(1171, 365);
            this.pgeZoneConvert.TabIndex = 0;
            this.pgeZoneConvert.Text = "Convert Between Zones";
            this.pgeZoneConvert.UseVisualStyleBackColor = true;
            // 
            // txtTargetOffset
            // 
            this.txtTargetOffset.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTargetOffset.Location = new System.Drawing.Point(649, 161);
            this.txtTargetOffset.Name = "txtTargetOffset";
            this.txtTargetOffset.Size = new System.Drawing.Size(111, 39);
            this.txtTargetOffset.TabIndex = 24;
            // 
            // txtSourceOffset
            // 
            this.txtSourceOffset.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSourceOffset.Location = new System.Drawing.Point(649, 112);
            this.txtSourceOffset.Name = "txtSourceOffset";
            this.txtSourceOffset.Size = new System.Drawing.Size(111, 39);
            this.txtSourceOffset.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(815, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 32);
            this.label14.TabIndex = 22;
            this.label14.Text = "Ticks:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTab2SourceTicks
            // 
            this.txtTab2SourceTicks.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTab2SourceTicks.Location = new System.Drawing.Point(885, 38);
            this.txtTab2SourceTicks.Name = "txtTab2SourceTicks";
            this.txtTab2SourceTicks.Size = new System.Drawing.Size(278, 39);
            this.txtTab2SourceTicks.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(745, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 32);
            this.label2.TabIndex = 20;
            this.label2.Text = "UTC Ticks:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(723, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 32);
            this.label1.TabIndex = 19;
            this.label1.Text = "Target Ticks:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMillisecondsFromUtc
            // 
            this.lblMillisecondsFromUtc.AutoSize = true;
            this.lblMillisecondsFromUtc.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMillisecondsFromUtc.Location = new System.Drawing.Point(66, 309);
            this.lblMillisecondsFromUtc.Name = "lblMillisecondsFromUtc";
            this.lblMillisecondsFromUtc.Size = new System.Drawing.Size(151, 32);
            this.lblMillisecondsFromUtc.TabIndex = 18;
            this.lblMillisecondsFromUtc.Text = "Milliseconds:";
            this.lblMillisecondsFromUtc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUtcDateAndTime
            // 
            this.lblUtcDateAndTime.AutoSize = true;
            this.lblUtcDateAndTime.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUtcDateAndTime.Location = new System.Drawing.Point(38, 261);
            this.lblUtcDateAndTime.Name = "lblUtcDateAndTime";
            this.lblUtcDateAndTime.Size = new System.Drawing.Size(179, 32);
            this.lblUtcDateAndTime.TabIndex = 17;
            this.lblUtcDateAndTime.Text = "UTC Date Time:";
            this.lblUtcDateAndTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTargetDateAndTime
            // 
            this.lblTargetDateAndTime.AutoSize = true;
            this.lblTargetDateAndTime.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTargetDateAndTime.Location = new System.Drawing.Point(16, 213);
            this.lblTargetDateAndTime.Name = "lblTargetDateAndTime";
            this.lblTargetDateAndTime.Size = new System.Drawing.Size(201, 32);
            this.lblTargetDateAndTime.TabIndex = 16;
            this.lblTargetDateAndTime.Text = "Target Date Time:";
            this.lblTargetDateAndTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTargetTimeZone
            // 
            this.lblTargetTimeZone.AutoSize = true;
            this.lblTargetTimeZone.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTargetTimeZone.Location = new System.Drawing.Point(18, 165);
            this.lblTargetTimeZone.Name = "lblTargetTimeZone";
            this.lblTargetTimeZone.Size = new System.Drawing.Size(199, 32);
            this.lblTargetTimeZone.TabIndex = 15;
            this.lblTargetTimeZone.Text = "Target TimeZone:";
            this.lblTargetTimeZone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSourceTimeZone
            // 
            this.lblSourceTimeZone.AutoSize = true;
            this.lblSourceTimeZone.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSourceTimeZone.Location = new System.Drawing.Point(10, 116);
            this.lblSourceTimeZone.Name = "lblSourceTimeZone";
            this.lblSourceTimeZone.Size = new System.Drawing.Size(207, 32);
            this.lblSourceTimeZone.TabIndex = 14;
            this.lblSourceTimeZone.Text = "Source TimeZone:";
            this.lblSourceTimeZone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblInputDate
            // 
            this.lblInputDate.AutoSize = true;
            this.lblInputDate.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInputDate.Location = new System.Drawing.Point(40, 22);
            this.lblInputDate.Name = "lblInputDate";
            this.lblInputDate.Size = new System.Drawing.Size(177, 64);
            this.lblInputDate.TabIndex = 13;
            this.lblInputDate.Text = "Select a Source\r\nDate and Time:";
            this.lblInputDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pgeTicksConvert
            // 
            this.pgeTicksConvert.Controls.Add(this.label17);
            this.pgeTicksConvert.Controls.Add(this.label19);
            this.pgeTicksConvert.Controls.Add(this.txtTab3Ticks);
            this.pgeTicksConvert.Controls.Add(this.txtTab3DateTime);
            this.pgeTicksConvert.Controls.Add(this.btnTab3Convert);
            this.pgeTicksConvert.Location = new System.Drawing.Point(4, 41);
            this.pgeTicksConvert.Name = "pgeTicksConvert";
            this.pgeTicksConvert.Size = new System.Drawing.Size(1171, 365);
            this.pgeTicksConvert.TabIndex = 2;
            this.pgeTicksConvert.Text = "Convert From Ticks";
            this.pgeTicksConvert.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(173, 30);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 32);
            this.label17.TabIndex = 49;
            this.label17.Text = "Ticks:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(115, 103);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(129, 32);
            this.label19.TabIndex = 47;
            this.label19.Text = "Date Time:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTab3Ticks
            // 
            this.txtTab3Ticks.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTab3Ticks.Location = new System.Drawing.Point(252, 27);
            this.txtTab3Ticks.Name = "txtTab3Ticks";
            this.txtTab3Ticks.Size = new System.Drawing.Size(422, 39);
            this.txtTab3Ticks.TabIndex = 43;
            // 
            // txtTab3DateTime
            // 
            this.txtTab3DateTime.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTab3DateTime.Location = new System.Drawing.Point(252, 100);
            this.txtTab3DateTime.Name = "txtTab3DateTime";
            this.txtTab3DateTime.Size = new System.Drawing.Size(422, 39);
            this.txtTab3DateTime.TabIndex = 42;
            // 
            // btnTab3Convert
            // 
            this.btnTab3Convert.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTab3Convert.Location = new System.Drawing.Point(252, 160);
            this.btnTab3Convert.Name = "btnTab3Convert";
            this.btnTab3Convert.Size = new System.Drawing.Size(113, 45);
            this.btnTab3Convert.TabIndex = 41;
            this.btnTab3Convert.Text = "&Convert";
            this.btnTab3Convert.UseVisualStyleBackColor = true;
            this.btnTab3Convert.Click += new System.EventHandler(this.btnTab3Convert_Click);
            // 
            // tabIcons
            // 
            this.tabIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.tabIcons.ImageSize = new System.Drawing.Size(16, 16);
            this.tabIcons.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 506);
            this.Controls.Add(this.tabUtils);
            this.Name = "Main";
            this.Text = "Temporal Conversion Machine";
            this.tabUtils.ResumeLayout(false);
            this.pgeMsConvert.ResumeLayout(false);
            this.pgeMsConvert.PerformLayout();
            this.pgeDateConvert.ResumeLayout(false);
            this.pgeDateConvert.PerformLayout();
            this.pgeZoneConvert.ResumeLayout(false);
            this.pgeZoneConvert.PerformLayout();
            this.pgeTicksConvert.ResumeLayout(false);
            this.pgeTicksConvert.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpTab2Date;
        private System.Windows.Forms.ComboBox cboTab2SourceTimeZoneChooser;
        private System.Windows.Forms.DateTimePicker dtpTab2Time;
        private System.Windows.Forms.TextBox txtTab2UTC;
        private System.Windows.Forms.Button btnTab2ConvertDates;
        private System.Windows.Forms.ComboBox cboTab2TargetTimeZoneChooser;
        private System.Windows.Forms.TextBox txtTab2TargetDate;
        private System.Windows.Forms.TextBox txtTab2TargetEpoch;
        private System.Windows.Forms.TextBox txtTab2LocalTicks;
        private System.Windows.Forms.TextBox txtTab2UtcTicks;
        private System.Windows.Forms.TabControl tabUtils;
        private System.Windows.Forms.TabPage pgeZoneConvert;
        private System.Windows.Forms.Label lblInputDate;
        private System.Windows.Forms.TabPage pgeMsConvert;
        private System.Windows.Forms.Label lblSourceTimeZone;
        private System.Windows.Forms.Label lblMillisecondsFromUtc;
        private System.Windows.Forms.Label lblUtcDateAndTime;
        private System.Windows.Forms.Label lblTargetDateAndTime;
        private System.Windows.Forms.Label lblTargetTimeZone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblForTargetTimezone;
        private System.Windows.Forms.TextBox txtTab0MillisecondsInput;
        private System.Windows.Forms.TextBox txtTab0UTCTickFromMs;
        private System.Windows.Forms.TextBox txtTab0LocalDateTime;
        private System.Windows.Forms.Button btnTab0Convert;
        private System.Windows.Forms.TextBox txtTab0LocalTickFromMs;
        private System.Windows.Forms.TextBox txtTab0UTCDateTime;
        private System.Windows.Forms.ComboBox cboTab0TimeZone;
        private System.Windows.Forms.TabPage pgeTicksConvert;
        private System.Windows.Forms.TabPage pgeDateConvert;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpTab1Time;
        private System.Windows.Forms.TextBox txtTab1Milliseconds;
        private System.Windows.Forms.TextBox txtTab1UTCTicks;
        private System.Windows.Forms.TextBox txtTab1LocalDateTime;
        private System.Windows.Forms.Button btnTab1Convert;
        private System.Windows.Forms.ComboBox cboTab1TimeZones;
        private System.Windows.Forms.TextBox txtTab1LocalTicks;
        private System.Windows.Forms.TextBox txtTab1UTCDateTime;
        private System.Windows.Forms.DateTimePicker dtpTab1Date;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtTab3Ticks;
        private System.Windows.Forms.TextBox txtTab3DateTime;
        private System.Windows.Forms.Button btnTab3Convert;
        private ImageList tabIcons;
        private TextBox txtTab2SourceTicks;
        private Label label14;
        private TextBox txtTargetOffset;
        private TextBox txtSourceOffset;
    }
}

