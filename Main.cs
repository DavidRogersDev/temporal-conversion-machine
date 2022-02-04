using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using DateConverter.Assets;
using DateConverter.Infrastructure;

namespace DateConverter
{
    public partial class Main : Form
    {
        private readonly string _defaultCity;

        public Main(string defaultCity)
        {
            _defaultCity = defaultCity;

            InitializeComponent();

            SetTabIcons();

            Icon = AppResources.TemporalConvertionMachine;
        }

        private void SetTabIcons()
        {
            tabIcons.ColorDepth = ColorDepth.Depth8Bit;
            tabIcons.ImageSize = new System.Drawing.Size(32, 32);
            tabIcons.TransparentColor = System.Drawing.Color.Transparent;

            tabIcons.Images.Add(AppResources.TabIcons_MsTab, AppResources.FromMilliseconds);
            tabIcons.Images.Add(AppResources.TabIcons_DateTab, AppResources.FromDate);
            tabIcons.Images.Add(AppResources.TabIcons_ZoneTab, AppResources.FromZone);
            tabIcons.Images.Add(AppResources.TabIcons_TicksTab, AppResources.FromTicks);

            pgeMsConvert.ImageKey = AppResources.TabIcons_MsTab;
            pgeDateConvert.ImageKey = AppResources.TabIcons_DateTab;
            pgeTicksConvert.ImageKey = AppResources.TabIcons_TicksTab;
            pgeZoneConvert.ImageKey = AppResources.TabIcons_ZoneTab;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            SetupTimeZones();

            SetTabIndex();

            txtTab0MillisecondsInput.Select();
        }

        private void SetupTimeZones()
        {
            SetupTimeZones(cboTab0TimeZone);
            SetupTimeZones(cboTab2TargetTimeZoneChooser);
            SetupTimeZones(cboTab2SourceTimeZoneChooser);
            SetupTimeZones(cboTab1TimeZones);
        }

        private void SetTabIndex()
        {
            int count = -1;

            txtTab0MillisecondsInput.TabIndex = ++count;
            txtTab0LocalDateTime.TabIndex = ++count;
            txtTab0UTCDateTime.TabIndex = ++count;
            txtTab0LocalTickFromMs.TabIndex = ++count;
            txtTab0UTCTickFromMs.TabIndex = ++count;
            cboTab0TimeZone.TabIndex = ++count;
            btnTab0Convert.TabIndex = ++count;

            dtpTab1Date.TabIndex = ++count; 
            dtpTab1Time.TabIndex = ++count; 
            cboTab1TimeZones.TabIndex = ++count; 
            txtTab1LocalDateTime.TabIndex = ++count;
            txtTab1UTCDateTime.TabIndex = ++count; 
            txtTab1Milliseconds.TabIndex = ++count; 
            txtTab1LocalTicks.TabIndex = ++count; 
            txtTab1UTCTicks.TabIndex = ++count; 
            
            dtpTab2Date.TabIndex = ++count; 
            dtpTab2Time.TabIndex = ++count;
            cboTab2SourceTimeZoneChooser.TabIndex = ++count;
            cboTab2TargetTimeZoneChooser.TabIndex = ++count;
            txtTab2TargetDate.TabIndex = ++count; 
            txtTab2UTC.TabIndex = ++count;
            txtTab2TargetEpoch.TabIndex = ++count; 
            txtTab2LocalTicks.TabIndex = ++count; 
            txtTab2UtcTicks.TabIndex = ++count; 
            btnTab2ConvertDates.TabIndex = ++count;

            txtTab3Ticks.TabIndex = ++count;
            txtTab3DateTime.TabIndex = ++count;
            btnTab3Convert.TabIndex = ++count;
        }

        private void SetupTimeZones(ComboBox timeZoneChooser)
        {
            timeZoneChooser.DataSource = Time.Ti.Select(d => new ZonedPlace
            {
                ZoneId = d.Key.Trim(),
                Place = d.Value.Trim()
            }).ToList();

            timeZoneChooser.DisplayMember = nameof(ZonedPlace.Place);
            timeZoneChooser.ValueMember = nameof(ZonedPlace.ZoneId);

            timeZoneChooser.SelectedItem =
                (timeZoneChooser.DataSource as IEnumerable<ZonedPlace>).Single(zonedPlace => zonedPlace.Place.Equals(_defaultCity, StringComparison.OrdinalIgnoreCase));
        }


        private void btnTab2ConvertDates_Click(object sender, EventArgs e)
        {
            var timeService = new TimeService();

            var sourceZonedPlace = cboTab2SourceTimeZoneChooser.SelectedItem as ZonedPlace;
            var targetZonedPlace = cboTab2TargetTimeZoneChooser.SelectedItem as ZonedPlace;

            var selectedDate = dtpTab2Date.Value.Blend(dtpTab2Time.Value);
            var sourceDateTimeOffset = new DateTimeOffset(selectedDate, TimeZoneInfo.FindSystemTimeZoneById(sourceZonedPlace.ZoneId).GetUtcOffset(selectedDate));

            
            var targetDate = timeService.ConvertToZonedOffset(sourceDateTimeOffset, targetZonedPlace.ZoneId);

            var targetUtc = targetDate.ToUniversalTime();

            Trace.WriteLine(targetDate.ToUnixTimeMilliseconds());
            Trace.WriteLine(targetUtc.ToUnixTimeMilliseconds());
            Trace.WriteLine(targetDate.Ticks);
            Trace.WriteLine(targetUtc.Ticks);

            txtTab2TargetDate.Text = targetDate.ToDisplayString();
            txtTab2UTC.Text = targetUtc.ToDisplayString();

            txtTab2TargetEpoch.Text = targetDate.ToUnixTimeMilliseconds().ToString();

            txtTab2LocalTicks.Text = targetDate.Ticks.ToString();
            txtTab2UtcTicks.Text = targetUtc.Ticks.ToString();
        }

        private void btnTab0Convert_Click(object sender, EventArgs e)
        {
            var timeService = new TimeService();
         
            var milliseconds = long.Parse(txtTab0MillisecondsInput.Text, NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingWhite);

            var zonedPlace = cboTab0TimeZone.SelectedItem as ZonedPlace;

            var dateAsUtc = new DateTimeOffset(milliseconds * 10000L + DateTime.UnixEpoch.Ticks, TimeSpan.Zero);
            var targetDate = timeService.ConvertToZonedOffset(dateAsUtc, zonedPlace.ZoneId);

            txtTab0UTCDateTime.Text = dateAsUtc.ToDisplayString();
            txtTab0UTCTickFromMs.Text = dateAsUtc.Ticks.ToString();

            txtTab0LocalDateTime.Text = targetDate.ToDisplayString();
            txtTab0LocalTickFromMs.Text = targetDate.Ticks.ToString();
        }

        private void btnTab1Convert_Click(object sender, EventArgs e)
        {
            var timeService = new TimeService();

            var zonedPlace = cboTab1TimeZones.SelectedItem as ZonedPlace;

            var selectedDate = dtpTab1Date.Value.Blend(dtpTab1Time.Value);
            var sourceDateTimeOffset = new DateTimeOffset(selectedDate, TimeZoneInfo.FindSystemTimeZoneById(zonedPlace.ZoneId).GetUtcOffset(selectedDate));

            var targetDate = timeService.ConvertToZonedOffset(sourceDateTimeOffset, zonedPlace.ZoneId);

            var targetDateutc = targetDate.ToUniversalTime();

            txtTab1LocalDateTime.Text = targetDate.ToDisplayString();
            txtTab1UTCDateTime.Text = targetDateutc.ToDisplayString();

            txtTab1Milliseconds.Text = targetDate.ToUnixTimeMilliseconds().ToString();

            txtTab1LocalTicks.Text = selectedDate.Ticks.ToString();
            txtTab1UTCTicks.Text = targetDateutc.Ticks.ToString();
        }

        private void btnTab3Convert_Click(object sender, EventArgs e)
        {
            var ticks = long.Parse(txtTab3Ticks.Text, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite);

            var dateTime = new DateTime(ticks);

            txtTab3DateTime.Text = dateTime.ToDisplayString();
        }
    }
}
