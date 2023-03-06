
namespace API_ToHMI_Translate
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGauges.Core.Model.IndicatorState indicatorState1 = new DevExpress.XtraGauges.Core.Model.IndicatorState();
            DevExpress.XtraGauges.Core.Model.IndicatorState indicatorState2 = new DevExpress.XtraGauges.Core.Model.IndicatorState();
            DevExpress.XtraGauges.Core.Model.IndicatorState indicatorState3 = new DevExpress.XtraGauges.Core.Model.IndicatorState();
            DevExpress.XtraGauges.Core.Model.IndicatorState indicatorState4 = new DevExpress.XtraGauges.Core.Model.IndicatorState();
            DevExpress.XtraGauges.Core.Model.IndicatorState indicatorState5 = new DevExpress.XtraGauges.Core.Model.IndicatorState();
            DevExpress.XtraGauges.Core.Model.IndicatorState indicatorState6 = new DevExpress.XtraGauges.Core.Model.IndicatorState();
            DevExpress.XtraGauges.Core.Model.IndicatorState indicatorState7 = new DevExpress.XtraGauges.Core.Model.IndicatorState();
            DevExpress.XtraGauges.Core.Model.IndicatorState indicatorState8 = new DevExpress.XtraGauges.Core.Model.IndicatorState();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tpe_Arr = new DevExpress.XtraTab.XtraTabPage();
            this.gcl_Arr = new DevExpress.XtraGrid.GridControl();
            this.gvw_Arr = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Arr_FDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Arr_STD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Arr_STA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Arr_ATA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.arrtime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Arr_airLineIATA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Arr_airLineNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Arr_CodeShare = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Arr_DepartureAirPortIATA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Arr_airPlaneType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Arr_Bay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusarr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.notearr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Arr_Passanger = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Arr_Infant = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Arr_Reg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Arr_F_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pcl_Arr = new DevExpress.XtraEditors.PanelControl();
            this.lbl_Arr_Time = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gaugeControl1 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.stateIndicatorGauge1 = new DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorGauge();
            this.stateIndicatorComponent1 = new DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorComponent();
            this.tpe_Dep = new DevExpress.XtraTab.XtraTabPage();
            this.gcl_Dep = new DevExpress.XtraGrid.GridControl();
            this.gvw_Dep = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lbl_Dep_Time = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.gaugeControl2 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.stateIndicatorGauge2 = new DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorGauge();
            this.stateIndicatorComponent2 = new DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorComponent();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolbarFormControl1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormControl();
            this.toolbarFormManager1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tpe_Arr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcl_Arr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvw_Arr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcl_Arr)).BeginInit();
            this.pcl_Arr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stateIndicatorGauge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateIndicatorComponent1)).BeginInit();
            this.tpe_Dep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcl_Dep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvw_Dep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stateIndicatorGauge2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateIndicatorComponent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 31);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.tpe_Arr;
            this.xtraTabControl1.Size = new System.Drawing.Size(1748, 705);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpe_Arr,
            this.tpe_Dep});
            // 
            // tpe_Arr
            // 
            this.tpe_Arr.Controls.Add(this.gcl_Arr);
            this.tpe_Arr.Controls.Add(this.pcl_Arr);
            this.tpe_Arr.Name = "tpe_Arr";
            this.tpe_Arr.Size = new System.Drawing.Size(1746, 679);
            this.tpe_Arr.Text = "到站資訊";
            // 
            // gcl_Arr
            // 
            this.gcl_Arr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcl_Arr.Location = new System.Drawing.Point(0, 41);
            this.gcl_Arr.MainView = this.gvw_Arr;
            this.gcl_Arr.Name = "gcl_Arr";
            this.gcl_Arr.Size = new System.Drawing.Size(1746, 638);
            this.gcl_Arr.TabIndex = 1;
            this.gcl_Arr.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvw_Arr});
            // 
            // gvw_Arr
            // 
            this.gvw_Arr.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Arr_FDATE,
            this.Arr_STD,
            this.Arr_STA,
            this.Arr_ATA,
            this.arrtime,
            this.Arr_airLineIATA,
            this.Arr_airLineNum,
            this.Arr_CodeShare,
            this.Arr_DepartureAirPortIATA,
            this.Arr_airPlaneType,
            this.Arr_Bay,
            this.statusarr,
            this.notearr,
            this.Arr_Passanger,
            this.Arr_Infant,
            this.Arr_Reg,
            this.Arr_F_TYPE});
            this.gvw_Arr.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvw_Arr.GridControl = this.gcl_Arr;
            this.gvw_Arr.Name = "gvw_Arr";
            this.gvw_Arr.OptionsView.ColumnAutoWidth = false;
            this.gvw_Arr.OptionsView.ShowGroupPanel = false;
            // 
            // Arr_FDATE
            // 
            this.Arr_FDATE.Caption = "航班日期";
            this.Arr_FDATE.FieldName = "FDATE";
            this.Arr_FDATE.Name = "Arr_FDATE";
            this.Arr_FDATE.OptionsColumn.AllowEdit = false;
            this.Arr_FDATE.Visible = true;
            this.Arr_FDATE.VisibleIndex = 0;
            // 
            // Arr_STD
            // 
            this.Arr_STD.Caption = "表訂起飛時間";
            this.Arr_STD.FieldName = "STD";
            this.Arr_STD.Name = "Arr_STD";
            this.Arr_STD.OptionsColumn.AllowEdit = false;
            this.Arr_STD.Visible = true;
            this.Arr_STD.VisibleIndex = 9;
            this.Arr_STD.Width = 84;
            // 
            // Arr_STA
            // 
            this.Arr_STA.Caption = "表定到站時間";
            this.Arr_STA.FieldName = "STA";
            this.Arr_STA.Name = "Arr_STA";
            this.Arr_STA.OptionsColumn.AllowEdit = false;
            this.Arr_STA.Visible = true;
            this.Arr_STA.VisibleIndex = 7;
            this.Arr_STA.Width = 86;
            // 
            // Arr_ATA
            // 
            this.Arr_ATA.Caption = "實際到站時間";
            this.Arr_ATA.FieldName = "ATA";
            this.Arr_ATA.Name = "Arr_ATA";
            this.Arr_ATA.OptionsColumn.AllowEdit = false;
            this.Arr_ATA.Visible = true;
            this.Arr_ATA.VisibleIndex = 8;
            this.Arr_ATA.Width = 83;
            // 
            // arrtime
            // 
            this.arrtime.Caption = "航空公司報到站時間";
            this.arrtime.FieldName = "arrtime";
            this.arrtime.Name = "arrtime";
            this.arrtime.OptionsColumn.AllowEdit = false;
            this.arrtime.Visible = true;
            this.arrtime.VisibleIndex = 10;
            this.arrtime.Width = 123;
            // 
            // Arr_airLineIATA
            // 
            this.Arr_airLineIATA.Caption = "航空公司代碼(IATA)";
            this.Arr_airLineIATA.FieldName = "airLineIATA";
            this.Arr_airLineIATA.Name = "Arr_airLineIATA";
            this.Arr_airLineIATA.OptionsColumn.AllowEdit = false;
            this.Arr_airLineIATA.Visible = true;
            this.Arr_airLineIATA.VisibleIndex = 1;
            this.Arr_airLineIATA.Width = 118;
            // 
            // Arr_airLineNum
            // 
            this.Arr_airLineNum.Caption = "航班編號";
            this.Arr_airLineNum.FieldName = "airLineNum";
            this.Arr_airLineNum.Name = "Arr_airLineNum";
            this.Arr_airLineNum.OptionsColumn.AllowEdit = false;
            this.Arr_airLineNum.Visible = true;
            this.Arr_airLineNum.VisibleIndex = 2;
            // 
            // Arr_CodeShare
            // 
            this.Arr_CodeShare.Caption = "共享航班";
            this.Arr_CodeShare.FieldName = "CodeShare";
            this.Arr_CodeShare.Name = "Arr_CodeShare";
            this.Arr_CodeShare.OptionsColumn.AllowEdit = false;
            this.Arr_CodeShare.Visible = true;
            this.Arr_CodeShare.VisibleIndex = 4;
            // 
            // Arr_DepartureAirPortIATA
            // 
            this.Arr_DepartureAirPortIATA.Caption = "目的機場代碼(IATA)";
            this.Arr_DepartureAirPortIATA.FieldName = "DepartureAirPortIATA";
            this.Arr_DepartureAirPortIATA.Name = "Arr_DepartureAirPortIATA";
            this.Arr_DepartureAirPortIATA.OptionsColumn.AllowEdit = false;
            this.Arr_DepartureAirPortIATA.Visible = true;
            this.Arr_DepartureAirPortIATA.VisibleIndex = 3;
            this.Arr_DepartureAirPortIATA.Width = 119;
            // 
            // Arr_airPlaneType
            // 
            this.Arr_airPlaneType.Caption = "機型代碼";
            this.Arr_airPlaneType.FieldName = "airPlaneType";
            this.Arr_airPlaneType.Name = "Arr_airPlaneType";
            this.Arr_airPlaneType.OptionsColumn.AllowEdit = false;
            this.Arr_airPlaneType.Visible = true;
            this.Arr_airPlaneType.VisibleIndex = 5;
            // 
            // Arr_Bay
            // 
            this.Arr_Bay.Caption = "使用機坪";
            this.Arr_Bay.FieldName = "Bay";
            this.Arr_Bay.Name = "Arr_Bay";
            this.Arr_Bay.OptionsColumn.AllowEdit = false;
            this.Arr_Bay.Visible = true;
            this.Arr_Bay.VisibleIndex = 11;
            this.Arr_Bay.Width = 61;
            // 
            // statusarr
            // 
            this.statusarr.Caption = "航機狀態";
            this.statusarr.FieldName = "statusarr";
            this.statusarr.Name = "statusarr";
            this.statusarr.OptionsColumn.AllowEdit = false;
            this.statusarr.Visible = true;
            this.statusarr.VisibleIndex = 12;
            this.statusarr.Width = 57;
            // 
            // notearr
            // 
            this.notearr.Caption = "狀態原因";
            this.notearr.FieldName = "notearr";
            this.notearr.Name = "notearr";
            this.notearr.OptionsColumn.AllowEdit = false;
            this.notearr.Visible = true;
            this.notearr.VisibleIndex = 13;
            this.notearr.Width = 58;
            // 
            // Arr_Passanger
            // 
            this.Arr_Passanger.Caption = "航機載客人數";
            this.Arr_Passanger.FieldName = "Passanger";
            this.Arr_Passanger.Name = "Arr_Passanger";
            this.Arr_Passanger.OptionsColumn.AllowEdit = false;
            this.Arr_Passanger.Visible = true;
            this.Arr_Passanger.VisibleIndex = 14;
            this.Arr_Passanger.Width = 82;
            // 
            // Arr_Infant
            // 
            this.Arr_Infant.Caption = "航機載客未滿2歲人數";
            this.Arr_Infant.FieldName = "Infant";
            this.Arr_Infant.Name = "Arr_Infant";
            this.Arr_Infant.OptionsColumn.AllowEdit = false;
            this.Arr_Infant.Visible = true;
            this.Arr_Infant.VisibleIndex = 15;
            this.Arr_Infant.Width = 123;
            // 
            // Arr_Reg
            // 
            this.Arr_Reg.Caption = "航機編號";
            this.Arr_Reg.FieldName = "Reg";
            this.Arr_Reg.Name = "Arr_Reg";
            this.Arr_Reg.OptionsColumn.AllowEdit = false;
            this.Arr_Reg.Visible = true;
            this.Arr_Reg.VisibleIndex = 6;
            // 
            // Arr_F_TYPE
            // 
            this.Arr_F_TYPE.Caption = "航班屬性";
            this.Arr_F_TYPE.FieldName = "F_TYPE";
            this.Arr_F_TYPE.Name = "Arr_F_TYPE";
            this.Arr_F_TYPE.OptionsColumn.AllowEdit = false;
            this.Arr_F_TYPE.Visible = true;
            this.Arr_F_TYPE.VisibleIndex = 16;
            // 
            // pcl_Arr
            // 
            this.pcl_Arr.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pcl_Arr.Controls.Add(this.lbl_Arr_Time);
            this.pcl_Arr.Controls.Add(this.labelControl1);
            this.pcl_Arr.Controls.Add(this.gaugeControl1);
            this.pcl_Arr.Dock = System.Windows.Forms.DockStyle.Top;
            this.pcl_Arr.Location = new System.Drawing.Point(0, 0);
            this.pcl_Arr.Name = "pcl_Arr";
            this.pcl_Arr.Size = new System.Drawing.Size(1746, 41);
            this.pcl_Arr.TabIndex = 0;
            // 
            // lbl_Arr_Time
            // 
            this.lbl_Arr_Time.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbl_Arr_Time.Appearance.Options.UseFont = true;
            this.lbl_Arr_Time.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_Arr_Time.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_Arr_Time.Location = new System.Drawing.Point(199, 0);
            this.lbl_Arr_Time.Name = "lbl_Arr_Time";
            this.lbl_Arr_Time.Size = new System.Drawing.Size(549, 41);
            this.lbl_Arr_Time.TabIndex = 2;
            this.lbl_Arr_Time.Text = "NONE";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelControl1.Location = new System.Drawing.Point(43, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(156, 41);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "最後連線時間/訊息 :";
            // 
            // gaugeControl1
            // 
            this.gaugeControl1.BackColor = System.Drawing.Color.Transparent;
            this.gaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gaugeControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gaugeControl1.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.stateIndicatorGauge1});
            this.gaugeControl1.Location = new System.Drawing.Point(0, 0);
            this.gaugeControl1.Name = "gaugeControl1";
            this.gaugeControl1.Size = new System.Drawing.Size(43, 41);
            this.gaugeControl1.TabIndex = 0;
            // 
            // stateIndicatorGauge1
            // 
            this.stateIndicatorGauge1.Bounds = new System.Drawing.Rectangle(6, 6, 31, 29);
            this.stateIndicatorGauge1.Indicators.AddRange(new DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorComponent[] {
            this.stateIndicatorComponent1});
            this.stateIndicatorGauge1.Name = "stateIndicatorGauge1";
            // 
            // stateIndicatorComponent1
            // 
            this.stateIndicatorComponent1.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(124F, 124F);
            this.stateIndicatorComponent1.Name = "stateIndicatorComponent1";
            this.stateIndicatorComponent1.Size = new System.Drawing.SizeF(200F, 200F);
            this.stateIndicatorComponent1.StateIndex = 0;
            indicatorState1.Name = "State1";
            indicatorState1.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ElectricLight1;
            indicatorState2.Name = "State2";
            indicatorState2.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ElectricLight2;
            indicatorState3.Name = "State3";
            indicatorState3.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ElectricLight3;
            indicatorState4.Name = "State4";
            indicatorState4.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ElectricLight4;
            this.stateIndicatorComponent1.States.AddRange(new DevExpress.XtraGauges.Core.Model.IIndicatorState[] {
            indicatorState1,
            indicatorState2,
            indicatorState3,
            indicatorState4});
            // 
            // tpe_Dep
            // 
            this.tpe_Dep.Controls.Add(this.gcl_Dep);
            this.tpe_Dep.Controls.Add(this.panelControl1);
            this.tpe_Dep.Name = "tpe_Dep";
            this.tpe_Dep.Size = new System.Drawing.Size(1746, 679);
            this.tpe_Dep.Text = "離站資訊";
            // 
            // gcl_Dep
            // 
            this.gcl_Dep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcl_Dep.Location = new System.Drawing.Point(0, 41);
            this.gcl_Dep.MainView = this.gvw_Dep;
            this.gcl_Dep.Name = "gcl_Dep";
            this.gcl_Dep.Size = new System.Drawing.Size(1746, 638);
            this.gcl_Dep.TabIndex = 4;
            this.gcl_Dep.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvw_Dep});
            // 
            // gvw_Dep
            // 
            this.gvw_Dep.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn16,
            this.gridColumn17});
            this.gvw_Dep.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvw_Dep.GridControl = this.gcl_Dep;
            this.gvw_Dep.Name = "gvw_Dep";
            this.gvw_Dep.OptionsView.ColumnAutoWidth = false;
            this.gvw_Dep.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "航班日期";
            this.gridColumn1.FieldName = "FDATE";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "表定離站時間";
            this.gridColumn2.FieldName = "STD";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 7;
            this.gridColumn2.Width = 83;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "表定抵達時間";
            this.gridColumn3.FieldName = "STA";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 9;
            this.gridColumn3.Width = 86;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "實際離站時間";
            this.gridColumn4.FieldName = "ATD";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 8;
            this.gridColumn4.Width = 84;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "航空公司報離站時間";
            this.gridColumn5.FieldName = "deptime";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 10;
            this.gridColumn5.Width = 121;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "航空公司代碼(IATA)";
            this.gridColumn6.FieldName = "airLineIATA";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            this.gridColumn6.Width = 120;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "航班編號";
            this.gridColumn7.FieldName = "airLineNum";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 2;
            this.gridColumn7.Width = 63;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "共享航班";
            this.gridColumn8.FieldName = "CodeShare";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 4;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "目的機場代碼(IATA)";
            this.gridColumn9.FieldName = "ArrivalAirportIATA";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 3;
            this.gridColumn9.Width = 121;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "機型代碼";
            this.gridColumn10.FieldName = "airPlaneType";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 5;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "使用機坪";
            this.gridColumn11.FieldName = "Bay";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsColumn.AllowEdit = false;
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 11;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "航機狀態";
            this.gridColumn12.FieldName = "statusdep";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.OptionsColumn.AllowEdit = false;
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 12;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "狀態原因";
            this.gridColumn13.FieldName = "notedep";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.OptionsColumn.AllowEdit = false;
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 13;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "航機載客人數";
            this.gridColumn14.FieldName = "Passanger";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.OptionsColumn.AllowEdit = false;
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 14;
            this.gridColumn14.Width = 84;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "航機載客未滿2歲人數";
            this.gridColumn15.FieldName = "Infant";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.OptionsColumn.AllowEdit = false;
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 15;
            this.gridColumn15.Width = 125;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "航機編號";
            this.gridColumn16.FieldName = "Reg";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.OptionsColumn.AllowEdit = false;
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 6;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "航班屬性";
            this.gridColumn17.FieldName = "F_TYPE";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.OptionsColumn.AllowEdit = false;
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 16;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.lbl_Dep_Time);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.gaugeControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1746, 41);
            this.panelControl1.TabIndex = 3;
            // 
            // lbl_Dep_Time
            // 
            this.lbl_Dep_Time.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbl_Dep_Time.Appearance.Options.UseFont = true;
            this.lbl_Dep_Time.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_Dep_Time.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_Dep_Time.Location = new System.Drawing.Point(199, 0);
            this.lbl_Dep_Time.Name = "lbl_Dep_Time";
            this.lbl_Dep_Time.Size = new System.Drawing.Size(549, 41);
            this.lbl_Dep_Time.TabIndex = 2;
            this.lbl_Dep_Time.Text = "NONE";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelControl3.Location = new System.Drawing.Point(43, 0);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(156, 41);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "最後連線時間/訊息 :";
            // 
            // gaugeControl2
            // 
            this.gaugeControl2.BackColor = System.Drawing.Color.Transparent;
            this.gaugeControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gaugeControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.gaugeControl2.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.stateIndicatorGauge2});
            this.gaugeControl2.Location = new System.Drawing.Point(0, 0);
            this.gaugeControl2.Name = "gaugeControl2";
            this.gaugeControl2.Size = new System.Drawing.Size(43, 41);
            this.gaugeControl2.TabIndex = 0;
            // 
            // stateIndicatorGauge2
            // 
            this.stateIndicatorGauge2.Bounds = new System.Drawing.Rectangle(6, 6, 31, 29);
            this.stateIndicatorGauge2.Indicators.AddRange(new DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorComponent[] {
            this.stateIndicatorComponent2});
            this.stateIndicatorGauge2.Name = "stateIndicatorGauge2";
            // 
            // stateIndicatorComponent2
            // 
            this.stateIndicatorComponent2.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(124F, 124F);
            this.stateIndicatorComponent2.Name = "stateIndicatorComponent1";
            this.stateIndicatorComponent2.Size = new System.Drawing.SizeF(200F, 200F);
            this.stateIndicatorComponent2.StateIndex = 0;
            indicatorState5.Name = "State1";
            indicatorState5.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ElectricLight1;
            indicatorState6.Name = "State2";
            indicatorState6.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ElectricLight2;
            indicatorState7.Name = "State3";
            indicatorState7.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ElectricLight3;
            indicatorState8.Name = "State4";
            indicatorState8.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ElectricLight4;
            this.stateIndicatorComponent2.States.AddRange(new DevExpress.XtraGauges.Core.Model.IIndicatorState[] {
            indicatorState5,
            indicatorState6,
            indicatorState7,
            indicatorState8});
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "API_ToHMI_Translate";
            this.notifyIcon.Visible = true;
            // 
            // toolbarFormControl1
            // 
            this.toolbarFormControl1.Location = new System.Drawing.Point(0, 0);
            this.toolbarFormControl1.Manager = this.toolbarFormManager1;
            this.toolbarFormControl1.Name = "toolbarFormControl1";
            this.toolbarFormControl1.Size = new System.Drawing.Size(1748, 31);
            this.toolbarFormControl1.TabIndex = 1;
            this.toolbarFormControl1.TabStop = false;
            this.toolbarFormControl1.ToolbarForm = this;
            // 
            // toolbarFormManager1
            // 
            this.toolbarFormManager1.DockControls.Add(this.barDockControlTop);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlBottom);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlLeft);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlRight);
            this.toolbarFormManager1.Form = this;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 31);
            this.barDockControlTop.Manager = this.toolbarFormManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1748, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 736);
            this.barDockControlBottom.Manager = this.toolbarFormManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1748, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Manager = this.toolbarFormManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 705);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1748, 31);
            this.barDockControlRight.Manager = this.toolbarFormManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 705);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1748, 736);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.toolbarFormControl1);
            this.Name = "MainForm";
            this.Text = "API_ToHMI_Translate";
            this.ToolbarFormControl = this.toolbarFormControl1;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.tpe_Arr.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcl_Arr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvw_Arr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcl_Arr)).EndInit();
            this.pcl_Arr.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stateIndicatorGauge1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateIndicatorComponent1)).EndInit();
            this.tpe_Dep.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcl_Dep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvw_Dep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stateIndicatorGauge2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateIndicatorComponent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage tpe_Arr;
        private DevExpress.XtraGrid.GridControl gcl_Arr;
        private DevExpress.XtraGrid.Views.Grid.GridView gvw_Arr;
        private DevExpress.XtraEditors.PanelControl pcl_Arr;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl1;
        private DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorGauge stateIndicatorGauge1;
        private DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorComponent stateIndicatorComponent1;
        private DevExpress.XtraTab.XtraTabPage tpe_Dep;
        private DevExpress.XtraEditors.LabelControl lbl_Arr_Time;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lbl_Dep_Time;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl2;
        private DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorGauge stateIndicatorGauge2;
        private DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorComponent stateIndicatorComponent2;
        private System.Windows.Forms.Timer timer;
        private DevExpress.XtraGrid.Columns.GridColumn Arr_FDATE;
        private DevExpress.XtraGrid.Columns.GridColumn Arr_STD;
        private DevExpress.XtraGrid.Columns.GridColumn Arr_STA;
        private DevExpress.XtraGrid.Columns.GridColumn Arr_ATA;
        private DevExpress.XtraGrid.Columns.GridColumn arrtime;
        private DevExpress.XtraGrid.Columns.GridColumn Arr_airLineIATA;
        private DevExpress.XtraGrid.Columns.GridColumn Arr_airLineNum;
        private DevExpress.XtraGrid.Columns.GridColumn Arr_CodeShare;
        private DevExpress.XtraGrid.Columns.GridColumn Arr_DepartureAirPortIATA;
        private DevExpress.XtraGrid.Columns.GridColumn Arr_airPlaneType;
        private DevExpress.XtraGrid.Columns.GridColumn Arr_Bay;
        private DevExpress.XtraGrid.Columns.GridColumn statusarr;
        private DevExpress.XtraGrid.Columns.GridColumn notearr;
        private DevExpress.XtraGrid.Columns.GridColumn Arr_Passanger;
        private DevExpress.XtraGrid.Columns.GridColumn Arr_Infant;
        private DevExpress.XtraGrid.Columns.GridColumn Arr_Reg;
        private DevExpress.XtraGrid.Columns.GridColumn Arr_F_TYPE;
        private DevExpress.XtraGrid.GridControl gcl_Dep;
        private DevExpress.XtraGrid.Views.Grid.GridView gvw_Dep;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private DevExpress.XtraBars.ToolbarForm.ToolbarFormControl toolbarFormControl1;
        private DevExpress.XtraBars.ToolbarForm.ToolbarFormManager toolbarFormManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}