﻿namespace EjecutableEncriptador
{
    partial class winformGeneraFE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(winformGeneraFE));
            this.dgridTrxFacturas = new System.Windows.Forms.DataGridView();
            this.Mark = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Docid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soptypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sopnumbeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechahoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idImpuestoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mensajeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoContabilizado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Voidstts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MensajeEA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eBinAct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwCfdTransaccionesDeVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbBIdDoc = new System.Windows.Forms.ComboBox();
            this.cmbBEstado = new System.Windows.Forms.ComboBox();
            this.checkBoxEstado = new System.Windows.Forms.CheckBox();
            this.checkBoxIdDoc = new System.Windows.Forms.CheckBox();
            this.checkBoxNDoc = new System.Windows.Forms.CheckBox();
            this.checkBoxFecha = new System.Windows.Forms.CheckBox();
            this.dtPickerHasta = new System.Windows.Forms.DateTimePicker();
            this.dtPickerDesde = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBNumDocHasta = new System.Windows.Forms.TextBox();
            this.txtBNumDocDesde = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtbxMensajes = new System.Windows.Forms.TextBox();
            this.toolStripProgressBar2 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.genFacturaElectrónicaV10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsTextBoxUsuario = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripAccionesXML = new System.Windows.Forms.ToolStrip();
            this.tsButtonGenerar = new System.Windows.Forms.ToolStripButton();
            this.toolStripImpresion = new System.Windows.Forms.ToolStrip();
            this.tsddButtonImprimir = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsComboDestinoRep = new System.Windows.Forms.ToolStripComboBox();
            this.tsTextDesde = new System.Windows.Forms.ToolStripTextBox();
            this.tsTextHasta = new System.Windows.Forms.ToolStripTextBox();
            this.tsMenuImprimir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsButtonImprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripConsulta = new System.Windows.Forms.ToolStrip();
            this.tsDDButtonFiltroF = new System.Windows.Forms.ToolStripDropDownButton();
            this.hoyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ultimos7DíasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ultimos30diasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ultimos60DíasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesActualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripAccionesXMLOtros = new System.Windows.Forms.ToolStrip();
            this.tsButtonConsultaTimbre = new System.Windows.Forms.ToolStripButton();
            this.tsBtnAnulaElimina = new System.Windows.Forms.ToolStripButton();
            this.tsBtnArchivoMensual = new System.Windows.Forms.ToolStripButton();
            this.tsBtnAbrirXML = new System.Windows.Forms.ToolStripButton();
            this.tsConfirmaAnulaXml = new System.Windows.Forms.ToolStrip();
            this.tsLabelConfirma = new System.Windows.Forms.ToolStripLabel();
            this.tsButtonConfirmaAnulaXml = new System.Windows.Forms.ToolStripButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbBxCompannia = new System.Windows.Forms.ComboBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.toolStripEmailMas = new System.Windows.Forms.ToolStrip();
            this.tsBtnConfiguraMsj = new System.Windows.Forms.ToolStripButton();
            this.toolStripEmail = new System.Windows.Forms.ToolStrip();
            this.tsBtnEnviaEmail = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsPbProcesoActivo = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripPDF = new System.Windows.Forms.ToolStrip();
            this.tsBtnGeneraPDF = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBCliente = new System.Windows.Forms.TextBox();
            this.checkBoxCliente = new System.Windows.Forms.CheckBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBoxMark = new System.Windows.Forms.CheckBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.pBarProcesoActivo = new System.Windows.Forms.ProgressBar();
            this.tabCfdi = new System.Windows.Forms.TabControl();
            this.tabFacturas = new System.Windows.Forms.TabPage();
            this.tabCobros = new System.Windows.Forms.TabPage();
            this.cBoxMarcCobros = new System.Windows.Forms.CheckBox();
            this.dgridTrxCobros = new System.Windows.Forms.DataGridView();
            this.MarcaCobro = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.iddoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soptype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sopnumbe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechahoraDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreClienteDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idImpuestoClienteDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mensajeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mensajeEADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoActualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Isocurrc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabTraslados = new System.Windows.Forms.TabPage();
            this.dGridTraslados = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgridTrxFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCfdTransaccionesDeVentaBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStripAccionesXML.SuspendLayout();
            this.toolStripImpresion.SuspendLayout();
            this.toolStripConsulta.SuspendLayout();
            this.toolStripAccionesXMLOtros.SuspendLayout();
            this.tsConfirmaAnulaXml.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.toolStripEmailMas.SuspendLayout();
            this.toolStripEmail.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStripPDF.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabCfdi.SuspendLayout();
            this.tabFacturas.SuspendLayout();
            this.tabCobros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridTrxCobros)).BeginInit();
            this.tabTraslados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridTraslados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgridTrxFacturas
            // 
            this.dgridTrxFacturas.AllowUserToAddRows = false;
            this.dgridTrxFacturas.AllowUserToDeleteRows = false;
            this.dgridTrxFacturas.AllowUserToOrderColumns = true;
            this.dgridTrxFacturas.AutoGenerateColumns = false;
            this.dgridTrxFacturas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgridTrxFacturas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgridTrxFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridTrxFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mark,
            this.Docid,
            this.soptypeDataGridViewTextBoxColumn,
            this.sopnumbeDataGridViewTextBoxColumn,
            this.fechahoraDataGridViewTextBoxColumn,
            this.nombreClienteDataGridViewTextBoxColumn,
            this.idImpuestoClienteDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.mensajeDataGridViewTextBoxColumn,
            this.EstadoContabilizado,
            this.Voidstts,
            this.MensajeEA,
            this.eBinAct});
            this.dgridTrxFacturas.DataSource = this.vwCfdTransaccionesDeVentaBindingSource;
            this.dgridTrxFacturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgridTrxFacturas.Location = new System.Drawing.Point(0, 0);
            this.dgridTrxFacturas.Name = "dgridTrxFacturas";
            this.dgridTrxFacturas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgridTrxFacturas.RowHeadersWidth = 10;
            this.dgridTrxFacturas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgridTrxFacturas.Size = new System.Drawing.Size(990, 287);
            this.dgridTrxFacturas.TabIndex = 50;
            this.dgridTrxFacturas.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgridTrxFacturas_RowPostPaint_1);
            // 
            // Mark
            // 
            this.Mark.FalseValue = "0";
            this.Mark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mark.Frozen = true;
            this.Mark.HeaderText = "M";
            this.Mark.IndeterminateValue = "-1";
            this.Mark.Name = "Mark";
            this.Mark.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Mark.TrueValue = "1";
            this.Mark.Width = 20;
            // 
            // Docid
            // 
            this.Docid.DataPropertyName = "Docid";
            this.Docid.Frozen = true;
            this.Docid.HeaderText = "Id Doc.";
            this.Docid.Name = "Docid";
            this.Docid.ReadOnly = true;
            this.Docid.Width = 50;
            // 
            // soptypeDataGridViewTextBoxColumn
            // 
            this.soptypeDataGridViewTextBoxColumn.DataPropertyName = "Soptype";
            this.soptypeDataGridViewTextBoxColumn.Frozen = true;
            this.soptypeDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.soptypeDataGridViewTextBoxColumn.Name = "soptypeDataGridViewTextBoxColumn";
            this.soptypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.soptypeDataGridViewTextBoxColumn.Visible = false;
            this.soptypeDataGridViewTextBoxColumn.Width = 50;
            // 
            // sopnumbeDataGridViewTextBoxColumn
            // 
            this.sopnumbeDataGridViewTextBoxColumn.DataPropertyName = "Sopnumbe";
            this.sopnumbeDataGridViewTextBoxColumn.Frozen = true;
            this.sopnumbeDataGridViewTextBoxColumn.HeaderText = "Número Doc.";
            this.sopnumbeDataGridViewTextBoxColumn.Name = "sopnumbeDataGridViewTextBoxColumn";
            this.sopnumbeDataGridViewTextBoxColumn.ReadOnly = true;
            this.sopnumbeDataGridViewTextBoxColumn.Width = 115;
            // 
            // fechahoraDataGridViewTextBoxColumn
            // 
            this.fechahoraDataGridViewTextBoxColumn.DataPropertyName = "Fechahora";
            this.fechahoraDataGridViewTextBoxColumn.Frozen = true;
            this.fechahoraDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechahoraDataGridViewTextBoxColumn.Name = "fechahoraDataGridViewTextBoxColumn";
            this.fechahoraDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechahoraDataGridViewTextBoxColumn.Width = 80;
            // 
            // nombreClienteDataGridViewTextBoxColumn
            // 
            this.nombreClienteDataGridViewTextBoxColumn.DataPropertyName = "NombreCliente";
            this.nombreClienteDataGridViewTextBoxColumn.Frozen = true;
            this.nombreClienteDataGridViewTextBoxColumn.HeaderText = "Nombre Cliente";
            this.nombreClienteDataGridViewTextBoxColumn.Name = "nombreClienteDataGridViewTextBoxColumn";
            this.nombreClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreClienteDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nombreClienteDataGridViewTextBoxColumn.Width = 150;
            // 
            // idImpuestoClienteDataGridViewTextBoxColumn
            // 
            this.idImpuestoClienteDataGridViewTextBoxColumn.DataPropertyName = "IdImpuestoCliente";
            this.idImpuestoClienteDataGridViewTextBoxColumn.Frozen = true;
            this.idImpuestoClienteDataGridViewTextBoxColumn.HeaderText = "Id. de Impuesto";
            this.idImpuestoClienteDataGridViewTextBoxColumn.Name = "idImpuestoClienteDataGridViewTextBoxColumn";
            this.idImpuestoClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.Frozen = true;
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.Frozen = true;
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoDataGridViewTextBoxColumn.Visible = false;
            this.estadoDataGridViewTextBoxColumn.Width = 55;
            // 
            // mensajeDataGridViewTextBoxColumn
            // 
            this.mensajeDataGridViewTextBoxColumn.DataPropertyName = "Mensaje";
            this.mensajeDataGridViewTextBoxColumn.Frozen = true;
            this.mensajeDataGridViewTextBoxColumn.HeaderText = "Mensaje";
            this.mensajeDataGridViewTextBoxColumn.Name = "mensajeDataGridViewTextBoxColumn";
            this.mensajeDataGridViewTextBoxColumn.Width = 150;
            // 
            // EstadoContabilizado
            // 
            this.EstadoContabilizado.DataPropertyName = "EstadoContabilizado";
            this.EstadoContabilizado.Frozen = true;
            this.EstadoContabilizado.HeaderText = "Estado Contab.";
            this.EstadoContabilizado.Name = "EstadoContabilizado";
            this.EstadoContabilizado.Visible = false;
            // 
            // Voidstts
            // 
            this.Voidstts.DataPropertyName = "Voidstts";
            this.Voidstts.Frozen = true;
            this.Voidstts.HeaderText = "Anulado";
            this.Voidstts.Name = "Voidstts";
            this.Voidstts.Visible = false;
            // 
            // MensajeEA
            // 
            this.MensajeEA.DataPropertyName = "MensajeEA";
            this.MensajeEA.Frozen = true;
            this.MensajeEA.HeaderText = "Observaciones";
            this.MensajeEA.Name = "MensajeEA";
            this.MensajeEA.Width = 180;
            // 
            // eBinAct
            // 
            this.eBinAct.DataPropertyName = "EstadoActual";
            this.eBinAct.Frozen = true;
            this.eBinAct.HeaderText = "E";
            this.eBinAct.Name = "eBinAct";
            this.eBinAct.ReadOnly = true;
            this.eBinAct.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.eBinAct.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.eBinAct.Visible = false;
            this.eBinAct.Width = 20;
            // 
            // vwCfdTransaccionesDeVentaBindingSource
            // 
            this.vwCfdTransaccionesDeVentaBindingSource.DataSource = typeof(EjecutableEncriptador.vwCfdTransaccionesDeVenta);
            // 
            // cmbBIdDoc
            // 
            this.cmbBIdDoc.BackColor = System.Drawing.SystemColors.Window;
            this.cmbBIdDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBIdDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBIdDoc.FormattingEnabled = true;
            this.cmbBIdDoc.Location = new System.Drawing.Point(484, 3);
            this.cmbBIdDoc.Name = "cmbBIdDoc";
            this.cmbBIdDoc.Size = new System.Drawing.Size(92, 21);
            this.cmbBIdDoc.TabIndex = 32;
            // 
            // cmbBEstado
            // 
            this.cmbBEstado.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmbBEstado.DisplayMember = "todos";
            this.cmbBEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBEstado.FormattingEnabled = true;
            this.cmbBEstado.Items.AddRange(new object[] {
            "emitido",
            "no emitido",
            "inconsistente"});
            this.cmbBEstado.Location = new System.Drawing.Point(484, 23);
            this.cmbBEstado.Name = "cmbBEstado";
            this.cmbBEstado.Size = new System.Drawing.Size(92, 21);
            this.cmbBEstado.TabIndex = 36;
            // 
            // checkBoxEstado
            // 
            this.checkBoxEstado.AutoSize = true;
            this.checkBoxEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxEstado.Location = new System.Drawing.Point(376, 24);
            this.checkBoxEstado.Name = "checkBoxEstado";
            this.checkBoxEstado.Size = new System.Drawing.Size(56, 17);
            this.checkBoxEstado.TabIndex = 34;
            this.checkBoxEstado.Text = "Estado";
            this.checkBoxEstado.UseVisualStyleBackColor = true;
            // 
            // checkBoxIdDoc
            // 
            this.checkBoxIdDoc.AutoSize = true;
            this.checkBoxIdDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxIdDoc.Location = new System.Drawing.Point(376, 6);
            this.checkBoxIdDoc.Name = "checkBoxIdDoc";
            this.checkBoxIdDoc.Size = new System.Drawing.Size(106, 17);
            this.checkBoxIdDoc.TabIndex = 30;
            this.checkBoxIdDoc.Text = "Id. de documento";
            this.checkBoxIdDoc.UseVisualStyleBackColor = true;
            // 
            // checkBoxNDoc
            // 
            this.checkBoxNDoc.AutoSize = true;
            this.checkBoxNDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxNDoc.Location = new System.Drawing.Point(10, 6);
            this.checkBoxNDoc.Name = "checkBoxNDoc";
            this.checkBoxNDoc.Size = new System.Drawing.Size(119, 17);
            this.checkBoxNDoc.TabIndex = 18;
            this.checkBoxNDoc.Text = "Núm. de documento";
            this.checkBoxNDoc.UseVisualStyleBackColor = true;
            // 
            // checkBoxFecha
            // 
            this.checkBoxFecha.AutoSize = true;
            this.checkBoxFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxFecha.Location = new System.Drawing.Point(10, 24);
            this.checkBoxFecha.Name = "checkBoxFecha";
            this.checkBoxFecha.Size = new System.Drawing.Size(53, 17);
            this.checkBoxFecha.TabIndex = 24;
            this.checkBoxFecha.Text = "Fecha";
            this.checkBoxFecha.UseVisualStyleBackColor = true;
            // 
            // dtPickerHasta
            // 
            this.dtPickerHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerHasta.Location = new System.Drawing.Point(274, 23);
            this.dtPickerHasta.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtPickerHasta.Name = "dtPickerHasta";
            this.dtPickerHasta.Size = new System.Drawing.Size(92, 20);
            this.dtPickerHasta.TabIndex = 28;
            // 
            // dtPickerDesde
            // 
            this.dtPickerDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerDesde.Location = new System.Drawing.Point(156, 23);
            this.dtPickerDesde.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtPickerDesde.Name = "dtPickerDesde";
            this.dtPickerDesde.Size = new System.Drawing.Size(92, 20);
            this.dtPickerDesde.TabIndex = 26;
            this.dtPickerDesde.Value = new System.DateTime(2010, 10, 29, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "De:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "De:";
            // 
            // txtBNumDocHasta
            // 
            this.txtBNumDocHasta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBNumDocHasta.Location = new System.Drawing.Point(274, 3);
            this.txtBNumDocHasta.Name = "txtBNumDocHasta";
            this.txtBNumDocHasta.Size = new System.Drawing.Size(92, 20);
            this.txtBNumDocHasta.TabIndex = 22;
            // 
            // txtBNumDocDesde
            // 
            this.txtBNumDocDesde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBNumDocDesde.Location = new System.Drawing.Point(156, 3);
            this.txtBNumDocDesde.Name = "txtBNumDocDesde";
            this.txtBNumDocDesde.Size = new System.Drawing.Size(92, 20);
            this.txtBNumDocDesde.TabIndex = 20;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 531);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1004, 10);
            this.progressBar1.Step = 4;
            this.progressBar1.TabIndex = 6;
            // 
            // txtbxMensajes
            // 
            this.txtbxMensajes.AcceptsReturn = true;
            this.txtbxMensajes.BackColor = System.Drawing.SystemColors.Info;
            this.txtbxMensajes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxMensajes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtbxMensajes.Location = new System.Drawing.Point(0, 493);
            this.txtbxMensajes.Multiline = true;
            this.txtbxMensajes.Name = "txtbxMensajes";
            this.txtbxMensajes.ReadOnly = true;
            this.txtbxMensajes.Size = new System.Drawing.Size(1004, 38);
            this.txtbxMensajes.TabIndex = 60;
            // 
            // toolStripProgressBar2
            // 
            this.toolStripProgressBar2.Name = "toolStripProgressBar2";
            this.toolStripProgressBar2.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(109, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(3, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(272, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(60, 24);
            this.toolStripMenuItem1.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.salirToolStripMenuItem.Text = "Cerrar";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genFacturaElectrónicaV10ToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(80, 24);
            this.toolStripMenuItem3.Text = "Acerca de...";
            // 
            // genFacturaElectrónicaV10ToolStripMenuItem
            // 
            this.genFacturaElectrónicaV10ToolStripMenuItem.Name = "genFacturaElectrónicaV10ToolStripMenuItem";
            this.genFacturaElectrónicaV10ToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.genFacturaElectrónicaV10ToolStripMenuItem.Text = "Factura Electrónica CFDI 3.3 v.7.3.1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(55, 24);
            this.toolStripMenuItem2.Text = "Archivo";
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            // 
            // tsTextBoxUsuario
            // 
            this.tsTextBoxUsuario.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsTextBoxUsuario.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tsTextBoxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tsTextBoxUsuario.Name = "tsTextBoxUsuario";
            this.tsTextBoxUsuario.ReadOnly = true;
            this.tsTextBoxUsuario.Size = new System.Drawing.Size(200, 23);
            this.tsTextBoxUsuario.Text = "usuario";
            // 
            // toolStripAccionesXML
            // 
            this.toolStripAccionesXML.AutoSize = false;
            this.toolStripAccionesXML.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripAccionesXML.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripAccionesXML.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsButtonGenerar});
            this.toolStripAccionesXML.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStripAccionesXML.Location = new System.Drawing.Point(3, 0);
            this.toolStripAccionesXML.Name = "toolStripAccionesXML";
            this.toolStripAccionesXML.Size = new System.Drawing.Size(87, 88);
            this.toolStripAccionesXML.TabIndex = 50;
            this.toolStripAccionesXML.Text = "toolStrip1";
            // 
            // tsButtonGenerar
            // 
            this.tsButtonGenerar.Image = global::EjecutableEncriptador.Properties.Resources.process;
            this.tsButtonGenerar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsButtonGenerar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonGenerar.Name = "tsButtonGenerar";
            this.tsButtonGenerar.Size = new System.Drawing.Size(91, 68);
            this.tsButtonGenerar.Text = "  Generar XML  ";
            this.tsButtonGenerar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsButtonGenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsButtonGenerar.ToolTipText = "Generación masiva de archivos Xml";
            this.tsButtonGenerar.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripImpresion
            // 
            this.toolStripImpresion.AutoSize = false;
            this.toolStripImpresion.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripImpresion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddButtonImprimir,
            this.tsButtonImprimir});
            this.toolStripImpresion.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStripImpresion.Location = new System.Drawing.Point(292, 0);
            this.toolStripImpresion.Name = "toolStripImpresion";
            this.toolStripImpresion.Size = new System.Drawing.Size(112, 88);
            this.toolStripImpresion.TabIndex = 60;
            this.toolStripImpresion.Text = "toolStrip2";
            // 
            // tsddButtonImprimir
            // 
            this.tsddButtonImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsddButtonImprimir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsComboDestinoRep,
            this.tsTextDesde,
            this.tsTextHasta,
            this.tsMenuImprimir});
            this.tsddButtonImprimir.Image = ((System.Drawing.Image)(resources.GetObject("tsddButtonImprimir.Image")));
            this.tsddButtonImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddButtonImprimir.Name = "tsddButtonImprimir";
            this.tsddButtonImprimir.Size = new System.Drawing.Size(29, 20);
            this.tsddButtonImprimir.Text = "Imprimir2";
            this.tsddButtonImprimir.ToolTipText = "Imprimir";
            this.tsddButtonImprimir.Click += new System.EventHandler(this.tsddButtonImprimir_Click);
            // 
            // tsComboDestinoRep
            // 
            this.tsComboDestinoRep.Enabled = false;
            this.tsComboDestinoRep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tsComboDestinoRep.Items.AddRange(new object[] {
            "Pantalla",
            "Impresora"});
            this.tsComboDestinoRep.Name = "tsComboDestinoRep";
            this.tsComboDestinoRep.Size = new System.Drawing.Size(121, 23);
            // 
            // tsTextDesde
            // 
            this.tsTextDesde.Name = "tsTextDesde";
            this.tsTextDesde.Size = new System.Drawing.Size(100, 23);
            this.tsTextDesde.Text = "Desde";
            this.tsTextDesde.ToolTipText = "Desde factura";
            // 
            // tsTextHasta
            // 
            this.tsTextHasta.Name = "tsTextHasta";
            this.tsTextHasta.Size = new System.Drawing.Size(100, 23);
            this.tsTextHasta.Text = "Hasta";
            // 
            // tsMenuImprimir
            // 
            this.tsMenuImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsMenuImprimir.Name = "tsMenuImprimir";
            this.tsMenuImprimir.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.tsMenuImprimir.Size = new System.Drawing.Size(181, 22);
            this.tsMenuImprimir.Text = "Imprimir";
            this.tsMenuImprimir.Click += new System.EventHandler(this.tsMenuImprimir_Click);
            // 
            // tsButtonImprimir
            // 
            this.tsButtonImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsButtonImprimir.Image = ((System.Drawing.Image)(resources.GetObject("tsButtonImprimir.Image")));
            this.tsButtonImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonImprimir.Name = "tsButtonImprimir";
            this.tsButtonImprimir.Size = new System.Drawing.Size(67, 19);
            this.tsButtonImprimir.Text = "Ver factura";
            this.tsButtonImprimir.Click += new System.EventHandler(this.tsButtonImprimir_Click);
            // 
            // toolStripConsulta
            // 
            this.toolStripConsulta.AutoSize = false;
            this.toolStripConsulta.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripConsulta.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsDDButtonFiltroF});
            this.toolStripConsulta.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStripConsulta.Location = new System.Drawing.Point(602, 0);
            this.toolStripConsulta.Name = "toolStripConsulta";
            this.toolStripConsulta.Size = new System.Drawing.Size(99, 88);
            this.toolStripConsulta.TabIndex = 70;
            this.toolStripConsulta.Tag = "Restricciones";
            this.toolStripConsulta.Text = "Restricciones";
            // 
            // tsDDButtonFiltroF
            // 
            this.tsDDButtonFiltroF.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hoyToolStripMenuItem,
            this.ayerToolStripMenuItem,
            this.ultimos7DíasToolStripMenuItem,
            this.ultimos30diasToolStripMenuItem,
            this.ultimos60DíasToolStripMenuItem,
            this.mesActualToolStripMenuItem});
            this.tsDDButtonFiltroF.Image = ((System.Drawing.Image)(resources.GetObject("tsDDButtonFiltroF.Image")));
            this.tsDDButtonFiltroF.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDDButtonFiltroF.Name = "tsDDButtonFiltroF";
            this.tsDDButtonFiltroF.Size = new System.Drawing.Size(88, 20);
            this.tsDDButtonFiltroF.Text = "Hoy          ";
            this.tsDDButtonFiltroF.TextChanged += new System.EventHandler(this.tsDDButtonFiltroF_TextChanged);
            // 
            // hoyToolStripMenuItem
            // 
            this.hoyToolStripMenuItem.Name = "hoyToolStripMenuItem";
            this.hoyToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.hoyToolStripMenuItem.Text = "Hoy          ";
            this.hoyToolStripMenuItem.Click += new System.EventHandler(this.hoyToolStripMenuItem_Click);
            // 
            // ayerToolStripMenuItem
            // 
            this.ayerToolStripMenuItem.Name = "ayerToolStripMenuItem";
            this.ayerToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.ayerToolStripMenuItem.Text = "Ayer             ";
            this.ayerToolStripMenuItem.Click += new System.EventHandler(this.ayerToolStripMenuItem_Click);
            // 
            // ultimos7DíasToolStripMenuItem
            // 
            this.ultimos7DíasToolStripMenuItem.Name = "ultimos7DíasToolStripMenuItem";
            this.ultimos7DíasToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.ultimos7DíasToolStripMenuItem.Tag = "";
            this.ultimos7DíasToolStripMenuItem.Text = "Ultimos 7 días";
            this.ultimos7DíasToolStripMenuItem.Click += new System.EventHandler(this.ultimos7DíasToolStripMenuItem_Click);
            // 
            // ultimos30diasToolStripMenuItem
            // 
            this.ultimos30diasToolStripMenuItem.Name = "ultimos30diasToolStripMenuItem";
            this.ultimos30diasToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.ultimos30diasToolStripMenuItem.Text = "Ultimos 30 días";
            this.ultimos30diasToolStripMenuItem.Click += new System.EventHandler(this.dToolStripMenuItem_Click);
            // 
            // ultimos60DíasToolStripMenuItem
            // 
            this.ultimos60DíasToolStripMenuItem.Name = "ultimos60DíasToolStripMenuItem";
            this.ultimos60DíasToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.ultimos60DíasToolStripMenuItem.Text = "Ultimos 60 días";
            this.ultimos60DíasToolStripMenuItem.Click += new System.EventHandler(this.ultimos60DíasToolStripMenuItem_Click);
            // 
            // mesActualToolStripMenuItem
            // 
            this.mesActualToolStripMenuItem.Name = "mesActualToolStripMenuItem";
            this.mesActualToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.mesActualToolStripMenuItem.Text = "Mes actual";
            this.mesActualToolStripMenuItem.Click += new System.EventHandler(this.mesActualToolStripMenuItem_Click);
            // 
            // toolStripAccionesXMLOtros
            // 
            this.toolStripAccionesXMLOtros.AutoSize = false;
            this.toolStripAccionesXMLOtros.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripAccionesXMLOtros.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripAccionesXMLOtros.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsButtonConsultaTimbre,
            this.tsBtnAnulaElimina,
            this.tsBtnArchivoMensual,
            this.tsBtnAbrirXML});
            this.toolStripAccionesXMLOtros.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStripAccionesXMLOtros.Location = new System.Drawing.Point(87, 0);
            this.toolStripAccionesXMLOtros.Name = "toolStripAccionesXMLOtros";
            this.toolStripAccionesXMLOtros.Size = new System.Drawing.Size(121, 88);
            this.toolStripAccionesXMLOtros.TabIndex = 18;
            this.toolStripAccionesXMLOtros.Text = "toolStrip1";
            // 
            // tsButtonConsultaTimbre
            // 
            this.tsButtonConsultaTimbre.Enabled = false;
            this.tsButtonConsultaTimbre.Image = ((System.Drawing.Image)(resources.GetObject("tsButtonConsultaTimbre.Image")));
            this.tsButtonConsultaTimbre.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonConsultaTimbre.Name = "tsButtonConsultaTimbre";
            this.tsButtonConsultaTimbre.Size = new System.Drawing.Size(112, 20);
            this.tsButtonConsultaTimbre.Text = "Consulta timbre";
            this.tsButtonConsultaTimbre.Click += new System.EventHandler(this.tsButtonConsultaTimbre_Click);
            // 
            // tsBtnAnulaElimina
            // 
            this.tsBtnAnulaElimina.AutoToolTip = false;
            this.tsBtnAnulaElimina.Enabled = false;
            this.tsBtnAnulaElimina.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnAnulaElimina.Image")));
            this.tsBtnAnulaElimina.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnAnulaElimina.Name = "tsBtnAnulaElimina";
            this.tsBtnAnulaElimina.Size = new System.Drawing.Size(137, 20);
            this.tsBtnAnulaElimina.Text = "Anular/Eliminar XML";
            this.tsBtnAnulaElimina.Visible = false;
            this.tsBtnAnulaElimina.Click += new System.EventHandler(this.tsBtnAnulaElimina_Click);
            // 
            // tsBtnArchivoMensual
            // 
            this.tsBtnArchivoMensual.Enabled = false;
            this.tsBtnArchivoMensual.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnArchivoMensual.Image")));
            this.tsBtnArchivoMensual.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnArchivoMensual.Name = "tsBtnArchivoMensual";
            this.tsBtnArchivoMensual.Size = new System.Drawing.Size(140, 20);
            this.tsBtnArchivoMensual.Text = "Genera código qr test";
            this.tsBtnArchivoMensual.ToolTipText = "Test";
            this.tsBtnArchivoMensual.Visible = false;
            this.tsBtnArchivoMensual.Click += new System.EventHandler(this.tsBtnArchivoMensual_Click);
            // 
            // tsBtnAbrirXML
            // 
            this.tsBtnAbrirXML.Enabled = false;
            this.tsBtnAbrirXML.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnAbrirXML.Image")));
            this.tsBtnAbrirXML.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnAbrirXML.Name = "tsBtnAbrirXML";
            this.tsBtnAbrirXML.Size = new System.Drawing.Size(98, 20);
            this.tsBtnAbrirXML.Text = "Abrir XML      ";
            this.tsBtnAbrirXML.Visible = false;
            this.tsBtnAbrirXML.Click += new System.EventHandler(this.tsBtnAbrirXML_Click);
            // 
            // tsConfirmaAnulaXml
            // 
            this.tsConfirmaAnulaXml.AutoSize = false;
            this.tsConfirmaAnulaXml.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsConfirmaAnulaXml.Dock = System.Windows.Forms.DockStyle.None;
            this.tsConfirmaAnulaXml.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLabelConfirma,
            this.tsButtonConfirmaAnulaXml});
            this.tsConfirmaAnulaXml.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tsConfirmaAnulaXml.Location = new System.Drawing.Point(140, 46);
            this.tsConfirmaAnulaXml.Name = "tsConfirmaAnulaXml";
            this.tsConfirmaAnulaXml.Size = new System.Drawing.Size(152, 67);
            this.tsConfirmaAnulaXml.TabIndex = 19;
            this.tsConfirmaAnulaXml.Text = "Confirmar";
            this.tsConfirmaAnulaXml.Visible = false;
            this.tsConfirmaAnulaXml.MouseLeave += new System.EventHandler(this.tsConfirmaAnulaXml_MouseLeave);
            // 
            // tsLabelConfirma
            // 
            this.tsLabelConfirma.AutoSize = false;
            this.tsLabelConfirma.Name = "tsLabelConfirma";
            this.tsLabelConfirma.Size = new System.Drawing.Size(125, 26);
            this.tsLabelConfirma.Text = "Confirmar anulación:";
            this.tsLabelConfirma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsButtonConfirmaAnulaXml
            // 
            this.tsButtonConfirmaAnulaXml.AutoSize = false;
            this.tsButtonConfirmaAnulaXml.AutoToolTip = false;
            this.tsButtonConfirmaAnulaXml.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tsButtonConfirmaAnulaXml.Checked = true;
            this.tsButtonConfirmaAnulaXml.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsButtonConfirmaAnulaXml.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsButtonConfirmaAnulaXml.Image = ((System.Drawing.Image)(resources.GetObject("tsButtonConfirmaAnulaXml.Image")));
            this.tsButtonConfirmaAnulaXml.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonConfirmaAnulaXml.Name = "tsButtonConfirmaAnulaXml";
            this.tsButtonConfirmaAnulaXml.Size = new System.Drawing.Size(75, 30);
            this.tsButtonConfirmaAnulaXml.Text = "Aceptar";
            this.tsButtonConfirmaAnulaXml.Click += new System.EventHandler(this.tsButtonConfirmaAnulaXml_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.menuStrip1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1004, 26);
            this.panel4.TabIndex = 74;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.cmbBxCompannia);
            this.panel2.Controls.Add(this.lblUsuario);
            this.panel2.Controls.Add(this.lblFecha);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(652, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 26);
            this.panel2.TabIndex = 17;
            // 
            // cmbBxCompannia
            // 
            this.cmbBxCompannia.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmbBxCompannia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxCompannia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBxCompannia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbBxCompannia.FormattingEnabled = true;
            this.cmbBxCompannia.Location = new System.Drawing.Point(150, 3);
            this.cmbBxCompannia.Name = "cmbBxCompannia";
            this.cmbBxCompannia.Size = new System.Drawing.Size(122, 21);
            this.cmbBxCompannia.TabIndex = 19;
            this.cmbBxCompannia.SelectedIndexChanged += new System.EventHandler(this.cmbBxCompannia_SelectedIndexChanged);
            this.cmbBxCompannia.TextChanged += new System.EventHandler(this.cmbBxCompannia_TextChanged);
            // 
            // lblUsuario
            // 
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblUsuario.Location = new System.Drawing.Point(3, 6);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUsuario.Size = new System.Drawing.Size(140, 17);
            this.lblUsuario.TabIndex = 18;
            // 
            // lblFecha
            // 
            this.lblFecha.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblFecha.Location = new System.Drawing.Point(277, 6);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(70, 13);
            this.lblFecha.TabIndex = 17;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.toolStripEmailMas);
            this.panel5.Controls.Add(this.toolStripEmail);
            this.panel5.Controls.Add(this.toolStrip1);
            this.panel5.Controls.Add(this.toolStripConsulta);
            this.panel5.Controls.Add(this.toolStripImpresion);
            this.panel5.Controls.Add(this.toolStripPDF);
            this.panel5.Controls.Add(this.toolStripAccionesXMLOtros);
            this.panel5.Controls.Add(this.toolStripAccionesXML);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 26);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1004, 88);
            this.panel5.TabIndex = 75;
            // 
            // toolStripEmailMas
            // 
            this.toolStripEmailMas.AutoSize = false;
            this.toolStripEmailMas.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEmailMas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnConfiguraMsj});
            this.toolStripEmailMas.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStripEmailMas.Location = new System.Drawing.Point(490, 0);
            this.toolStripEmailMas.Name = "toolStripEmailMas";
            this.toolStripEmailMas.Size = new System.Drawing.Size(112, 88);
            this.toolStripEmailMas.TabIndex = 74;
            this.toolStripEmailMas.Text = "toolStrip2";
            // 
            // tsBtnConfiguraMsj
            // 
            this.tsBtnConfiguraMsj.Enabled = false;
            this.tsBtnConfiguraMsj.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnConfiguraMsj.Image")));
            this.tsBtnConfiguraMsj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnConfiguraMsj.Name = "tsBtnConfiguraMsj";
            this.tsBtnConfiguraMsj.Size = new System.Drawing.Size(71, 20);
            this.tsBtnConfiguraMsj.Text = "Mensaje";
            this.tsBtnConfiguraMsj.Visible = false;
            // 
            // toolStripEmail
            // 
            this.toolStripEmail.AutoSize = false;
            this.toolStripEmail.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEmail.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnEnviaEmail});
            this.toolStripEmail.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStripEmail.Location = new System.Drawing.Point(404, 0);
            this.toolStripEmail.Name = "toolStripEmail";
            this.toolStripEmail.Size = new System.Drawing.Size(88, 88);
            this.toolStripEmail.TabIndex = 73;
            this.toolStripEmail.Text = "toolStripEmail";
            // 
            // tsBtnEnviaEmail
            // 
            this.tsBtnEnviaEmail.AutoSize = false;
            this.tsBtnEnviaEmail.Image = global::EjecutableEncriptador.Properties.Resources.emailG;
            this.tsBtnEnviaEmail.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsBtnEnviaEmail.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnEnviaEmail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnEnviaEmail.Name = "tsBtnEnviaEmail";
            this.tsBtnEnviaEmail.Size = new System.Drawing.Size(84, 66);
            this.tsBtnEnviaEmail.Text = "Enviar e-mail";
            this.tsBtnEnviaEmail.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsBtnEnviaEmail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnEnviaEmail.ToolTipText = "Envío masivo de e-mails";
            this.tsBtnEnviaEmail.Click += new System.EventHandler(this.tsBtnEnviaEmail_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsPbProcesoActivo});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(701, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(303, 88);
            this.toolStrip1.TabIndex = 72;
            this.toolStrip1.Tag = "";
            this.toolStrip1.Text = "Restricciones";
            // 
            // tsPbProcesoActivo
            // 
            this.tsPbProcesoActivo.Name = "tsPbProcesoActivo";
            this.tsPbProcesoActivo.Size = new System.Drawing.Size(100, 15);
            // 
            // toolStripPDF
            // 
            this.toolStripPDF.AutoSize = false;
            this.toolStripPDF.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripPDF.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnGeneraPDF});
            this.toolStripPDF.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStripPDF.Location = new System.Drawing.Point(208, 0);
            this.toolStripPDF.Name = "toolStripPDF";
            this.toolStripPDF.Size = new System.Drawing.Size(88, 88);
            this.toolStripPDF.TabIndex = 71;
            this.toolStripPDF.Text = "toolStrip2";
            // 
            // tsBtnGeneraPDF
            // 
            this.tsBtnGeneraPDF.AutoSize = false;
            this.tsBtnGeneraPDF.Image = global::EjecutableEncriptador.Properties.Resources.generapdf;
            this.tsBtnGeneraPDF.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnGeneraPDF.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnGeneraPDF.Name = "tsBtnGeneraPDF";
            this.tsBtnGeneraPDF.Size = new System.Drawing.Size(84, 66);
            this.tsBtnGeneraPDF.Text = "Generar PDF";
            this.tsBtnGeneraPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnGeneraPDF.ToolTipText = "Generación masiva de archivos PDF";
            this.tsBtnGeneraPDF.Click += new System.EventHandler(this.tsBtnGeneraPDF_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBCliente);
            this.panel1.Controls.Add(this.checkBoxCliente);
            this.panel1.Controls.Add(this.cmbBIdDoc);
            this.panel1.Controls.Add(this.txtBNumDocDesde);
            this.panel1.Controls.Add(this.dtPickerDesde);
            this.panel1.Controls.Add(this.cmbBEstado);
            this.panel1.Controls.Add(this.dtPickerHasta);
            this.panel1.Controls.Add(this.txtBNumDocHasta);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.checkBoxEstado);
            this.panel1.Controls.Add(this.checkBoxFecha);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.checkBoxIdDoc);
            this.panel1.Controls.Add(this.checkBoxNDoc);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 60);
            this.panel1.TabIndex = 76;
            // 
            // textBCliente
            // 
            this.textBCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBCliente.Location = new System.Drawing.Point(647, 3);
            this.textBCliente.Name = "textBCliente";
            this.textBCliente.Size = new System.Drawing.Size(168, 20);
            this.textBCliente.TabIndex = 42;
            // 
            // checkBoxCliente
            // 
            this.checkBoxCliente.AutoSize = true;
            this.checkBoxCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxCliente.Location = new System.Drawing.Point(590, 6);
            this.checkBoxCliente.Name = "checkBoxCliente";
            this.checkBoxCliente.Size = new System.Drawing.Size(55, 17);
            this.checkBoxCliente.TabIndex = 39;
            this.checkBoxCliente.Text = "Cliente";
            this.checkBoxCliente.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.Location = new System.Drawing.Point(821, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(84, 54);
            this.btnBuscar.TabIndex = 44;
            this.btnBuscar.Text = "Aplicar Filtro";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.checkBoxMark);
            this.panel3.Controls.Add(this.dgridTrxFacturas);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(990, 287);
            this.panel3.TabIndex = 77;
            // 
            // checkBoxMark
            // 
            this.checkBoxMark.AutoSize = true;
            this.checkBoxMark.Checked = true;
            this.checkBoxMark.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxMark.Location = new System.Drawing.Point(15, 12);
            this.checkBoxMark.Name = "checkBoxMark";
            this.checkBoxMark.Size = new System.Drawing.Size(12, 11);
            this.checkBoxMark.TabIndex = 42;
            this.checkBoxMark.UseVisualStyleBackColor = true;
            this.checkBoxMark.CheckedChanged += new System.EventHandler(this.checkBoxMark_CheckedChanged);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // pBarProcesoActivo
            // 
            this.pBarProcesoActivo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.pBarProcesoActivo.Location = new System.Drawing.Point(742, 507);
            this.pBarProcesoActivo.Name = "pBarProcesoActivo";
            this.pBarProcesoActivo.Size = new System.Drawing.Size(155, 13);
            this.pBarProcesoActivo.Step = 1;
            this.pBarProcesoActivo.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pBarProcesoActivo.TabIndex = 40;
            this.pBarProcesoActivo.Visible = false;
            // 
            // tabCfdi
            // 
            this.tabCfdi.Controls.Add(this.tabFacturas);
            this.tabCfdi.Controls.Add(this.tabCobros);
            this.tabCfdi.Controls.Add(this.tabTraslados);
            this.tabCfdi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCfdi.Location = new System.Drawing.Point(0, 174);
            this.tabCfdi.Name = "tabCfdi";
            this.tabCfdi.SelectedIndex = 0;
            this.tabCfdi.Size = new System.Drawing.Size(1004, 319);
            this.tabCfdi.TabIndex = 78;
            this.tabCfdi.SelectedIndexChanged += new System.EventHandler(this.tabCfdi_SelectedIndexChanged);
            // 
            // tabFacturas
            // 
            this.tabFacturas.AccessibleName = "";
            this.tabFacturas.Controls.Add(this.panel3);
            this.tabFacturas.Location = new System.Drawing.Point(4, 22);
            this.tabFacturas.Name = "tabFacturas";
            this.tabFacturas.Padding = new System.Windows.Forms.Padding(3);
            this.tabFacturas.Size = new System.Drawing.Size(996, 293);
            this.tabFacturas.TabIndex = 0;
            this.tabFacturas.Text = "FACTURAS     ";
            this.tabFacturas.UseVisualStyleBackColor = true;
            // 
            // tabCobros
            // 
            this.tabCobros.Controls.Add(this.cBoxMarcCobros);
            this.tabCobros.Controls.Add(this.dgridTrxCobros);
            this.tabCobros.Location = new System.Drawing.Point(4, 22);
            this.tabCobros.Name = "tabCobros";
            this.tabCobros.Padding = new System.Windows.Forms.Padding(3);
            this.tabCobros.Size = new System.Drawing.Size(996, 293);
            this.tabCobros.TabIndex = 1;
            this.tabCobros.Text = "COBROS     ";
            this.tabCobros.UseVisualStyleBackColor = true;
            // 
            // cBoxMarcCobros
            // 
            this.cBoxMarcCobros.AutoSize = true;
            this.cBoxMarcCobros.Checked = true;
            this.cBoxMarcCobros.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cBoxMarcCobros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxMarcCobros.Location = new System.Drawing.Point(17, 15);
            this.cBoxMarcCobros.Name = "cBoxMarcCobros";
            this.cBoxMarcCobros.Size = new System.Drawing.Size(12, 11);
            this.cBoxMarcCobros.TabIndex = 43;
            this.cBoxMarcCobros.UseVisualStyleBackColor = true;
            this.cBoxMarcCobros.CheckedChanged += new System.EventHandler(this.cBoxMarcCobros_CheckedChanged);
            // 
            // dgridTrxCobros
            // 
            this.dgridTrxCobros.AllowUserToAddRows = false;
            this.dgridTrxCobros.AllowUserToDeleteRows = false;
            this.dgridTrxCobros.AllowUserToOrderColumns = true;
            this.dgridTrxCobros.AutoGenerateColumns = false;
            this.dgridTrxCobros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgridTrxCobros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridTrxCobros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MarcaCobro,
            this.iddoc,
            this.Soptype,
            this.Sopnumbe,
            this.fechahoraDataGridViewTextBoxColumn1,
            this.nombreClienteDataGridViewTextBoxColumn1,
            this.idImpuestoClienteDataGridViewTextBoxColumn1,
            this.totalDataGridViewTextBoxColumn1,
            this.estadoDataGridViewTextBoxColumn1,
            this.mensajeDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.mensajeEADataGridViewTextBoxColumn,
            this.estadoActualDataGridViewTextBoxColumn,
            this.Isocurrc});
            this.dgridTrxCobros.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgridTrxCobros.DataSource = this.vwCfdTransaccionesDeVentaBindingSource;
            this.dgridTrxCobros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgridTrxCobros.Location = new System.Drawing.Point(3, 3);
            this.dgridTrxCobros.Name = "dgridTrxCobros";
            this.dgridTrxCobros.RowHeadersWidth = 10;
            this.dgridTrxCobros.Size = new System.Drawing.Size(990, 287);
            this.dgridTrxCobros.TabIndex = 0;
            this.dgridTrxCobros.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgridTrxCobros_RowPostPaint);
            // 
            // MarcaCobro
            // 
            this.MarcaCobro.FalseValue = "0";
            this.MarcaCobro.Frozen = true;
            this.MarcaCobro.HeaderText = "M";
            this.MarcaCobro.IndeterminateValue = "-1";
            this.MarcaCobro.Name = "MarcaCobro";
            this.MarcaCobro.TrueValue = "1";
            this.MarcaCobro.Width = 20;
            // 
            // iddoc
            // 
            this.iddoc.DataPropertyName = "docid";
            this.iddoc.HeaderText = "Id Doc";
            this.iddoc.Name = "iddoc";
            this.iddoc.Visible = false;
            // 
            // Soptype
            // 
            this.Soptype.DataPropertyName = "Soptype";
            this.Soptype.HeaderText = "Soptype";
            this.Soptype.Name = "Soptype";
            this.Soptype.Visible = false;
            // 
            // Sopnumbe
            // 
            this.Sopnumbe.DataPropertyName = "Sopnumbe";
            this.Sopnumbe.HeaderText = "Número Pago";
            this.Sopnumbe.Name = "Sopnumbe";
            this.Sopnumbe.Width = 110;
            // 
            // fechahoraDataGridViewTextBoxColumn1
            // 
            this.fechahoraDataGridViewTextBoxColumn1.DataPropertyName = "Fechahora";
            this.fechahoraDataGridViewTextBoxColumn1.HeaderText = "Fecha";
            this.fechahoraDataGridViewTextBoxColumn1.Name = "fechahoraDataGridViewTextBoxColumn1";
            this.fechahoraDataGridViewTextBoxColumn1.Width = 80;
            // 
            // nombreClienteDataGridViewTextBoxColumn1
            // 
            this.nombreClienteDataGridViewTextBoxColumn1.DataPropertyName = "NombreCliente";
            this.nombreClienteDataGridViewTextBoxColumn1.HeaderText = "Nombre Cliente";
            this.nombreClienteDataGridViewTextBoxColumn1.Name = "nombreClienteDataGridViewTextBoxColumn1";
            this.nombreClienteDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nombreClienteDataGridViewTextBoxColumn1.Width = 150;
            // 
            // idImpuestoClienteDataGridViewTextBoxColumn1
            // 
            this.idImpuestoClienteDataGridViewTextBoxColumn1.DataPropertyName = "IdImpuestoCliente";
            this.idImpuestoClienteDataGridViewTextBoxColumn1.HeaderText = "Id. de Impuesto";
            this.idImpuestoClienteDataGridViewTextBoxColumn1.Name = "idImpuestoClienteDataGridViewTextBoxColumn1";
            this.idImpuestoClienteDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn1
            // 
            this.totalDataGridViewTextBoxColumn1.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn1.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn1.Name = "totalDataGridViewTextBoxColumn1";
            this.totalDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn1
            // 
            this.estadoDataGridViewTextBoxColumn1.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn1.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn1.Name = "estadoDataGridViewTextBoxColumn1";
            this.estadoDataGridViewTextBoxColumn1.Visible = false;
            // 
            // mensajeDataGridViewTextBoxColumn1
            // 
            this.mensajeDataGridViewTextBoxColumn1.DataPropertyName = "Mensaje";
            this.mensajeDataGridViewTextBoxColumn1.HeaderText = "Mensaje";
            this.mensajeDataGridViewTextBoxColumn1.Name = "mensajeDataGridViewTextBoxColumn1";
            this.mensajeDataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EstadoContabilizado";
            this.dataGridViewTextBoxColumn1.HeaderText = "EstadoContab.";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Voidstts";
            this.dataGridViewTextBoxColumn2.HeaderText = "Anulado";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // mensajeEADataGridViewTextBoxColumn
            // 
            this.mensajeEADataGridViewTextBoxColumn.DataPropertyName = "MensajeEA";
            this.mensajeEADataGridViewTextBoxColumn.HeaderText = "Observaciones";
            this.mensajeEADataGridViewTextBoxColumn.Name = "mensajeEADataGridViewTextBoxColumn";
            this.mensajeEADataGridViewTextBoxColumn.Width = 180;
            // 
            // estadoActualDataGridViewTextBoxColumn
            // 
            this.estadoActualDataGridViewTextBoxColumn.DataPropertyName = "EstadoActual";
            this.estadoActualDataGridViewTextBoxColumn.HeaderText = "E";
            this.estadoActualDataGridViewTextBoxColumn.Name = "estadoActualDataGridViewTextBoxColumn";
            this.estadoActualDataGridViewTextBoxColumn.Visible = false;
            // 
            // Isocurrc
            // 
            this.Isocurrc.DataPropertyName = "Isocurrc";
            this.Isocurrc.HeaderText = "Mnda";
            this.Isocurrc.Name = "Isocurrc";
            this.Isocurrc.Width = 35;
            // 
            // tabTraslados
            // 
            this.tabTraslados.Controls.Add(this.dGridTraslados);
            this.tabTraslados.Location = new System.Drawing.Point(4, 22);
            this.tabTraslados.Name = "tabTraslados";
            this.tabTraslados.Size = new System.Drawing.Size(996, 293);
            this.tabTraslados.TabIndex = 2;
            this.tabTraslados.Text = "TRASLADOS";
            this.tabTraslados.UseVisualStyleBackColor = true;
            // 
            // dGridTraslados
            // 
            this.dGridTraslados.AllowUserToAddRows = false;
            this.dGridTraslados.AllowUserToDeleteRows = false;
            this.dGridTraslados.AllowUserToOrderColumns = true;
            this.dGridTraslados.AutoGenerateColumns = false;
            this.dGridTraslados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGridTraslados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridTraslados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.dGridTraslados.Cursor = System.Windows.Forms.Cursors.Default;
            this.dGridTraslados.DataSource = this.vwCfdTransaccionesDeVentaBindingSource;
            this.dGridTraslados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGridTraslados.Location = new System.Drawing.Point(0, 0);
            this.dGridTraslados.Name = "dGridTraslados";
            this.dGridTraslados.RowHeadersWidth = 10;
            this.dGridTraslados.Size = new System.Drawing.Size(996, 293);
            this.dGridTraslados.TabIndex = 1;
            this.dGridTraslados.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dGridTraslados_RowPostPaint);
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.FalseValue = "0";
            this.dataGridViewCheckBoxColumn1.Frozen = true;
            this.dataGridViewCheckBoxColumn1.HeaderText = "M";
            this.dataGridViewCheckBoxColumn1.IndeterminateValue = "-1";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.TrueValue = "1";
            this.dataGridViewCheckBoxColumn1.Width = 20;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "docid";
            this.dataGridViewTextBoxColumn3.HeaderText = "Id Doc";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Soptype";
            this.dataGridViewTextBoxColumn4.HeaderText = "Soptype";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Sopnumbe";
            this.dataGridViewTextBoxColumn5.HeaderText = "Número Transferencia";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 140;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Fechahora";
            this.dataGridViewTextBoxColumn6.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "NombreCliente";
            this.dataGridViewTextBoxColumn7.HeaderText = "Nombre Cliente";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "IdImpuestoCliente";
            this.dataGridViewTextBoxColumn8.HeaderText = "Id. de Impuesto";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Total";
            this.dataGridViewTextBoxColumn9.HeaderText = "Total";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Estado";
            this.dataGridViewTextBoxColumn10.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Mensaje";
            this.dataGridViewTextBoxColumn11.HeaderText = "Mensaje";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 300;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "EstadoContabilizado";
            this.dataGridViewTextBoxColumn12.HeaderText = "EstadoContab.";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Voidstts";
            this.dataGridViewTextBoxColumn13.HeaderText = "Anulado";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Visible = false;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "MensajeEA";
            this.dataGridViewTextBoxColumn14.HeaderText = "Observaciones";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 300;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "EstadoActual";
            this.dataGridViewTextBoxColumn15.HeaderText = "E";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Visible = false;
            // 
            // winformGeneraFE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 541);
            this.Controls.Add(this.tabCfdi);
            this.Controls.Add(this.pBarProcesoActivo);
            this.Controls.Add(this.tsConfirmaAnulaXml);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtbxMensajes);
            this.Controls.Add(this.progressBar1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "winformGeneraFE";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "GP Factura Electrónica";
            this.Load += new System.EventHandler(this.winformGeneraFE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridTrxFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCfdTransaccionesDeVentaBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripAccionesXML.ResumeLayout(false);
            this.toolStripAccionesXML.PerformLayout();
            this.toolStripImpresion.ResumeLayout(false);
            this.toolStripImpresion.PerformLayout();
            this.toolStripConsulta.ResumeLayout(false);
            this.toolStripConsulta.PerformLayout();
            this.toolStripAccionesXMLOtros.ResumeLayout(false);
            this.toolStripAccionesXMLOtros.PerformLayout();
            this.tsConfirmaAnulaXml.ResumeLayout(false);
            this.tsConfirmaAnulaXml.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.toolStripEmailMas.ResumeLayout(false);
            this.toolStripEmailMas.PerformLayout();
            this.toolStripEmail.ResumeLayout(false);
            this.toolStripEmail.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStripPDF.ResumeLayout(false);
            this.toolStripPDF.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabCfdi.ResumeLayout(false);
            this.tabFacturas.ResumeLayout(false);
            this.tabCobros.ResumeLayout(false);
            this.tabCobros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridTrxCobros)).EndInit();
            this.tabTraslados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGridTraslados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgridTrxFacturas;
        private System.Windows.Forms.BindingSource vwCfdTransaccionesDeVentaBindingSource;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txtBNumDocHasta;
        private System.Windows.Forms.TextBox txtBNumDocDesde;
        private System.Windows.Forms.TextBox txtbxMensajes;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox tsTextBoxUsuario;
        private System.Windows.Forms.ToolStrip toolStripAccionesXML;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton tsButtonGenerar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripImpresion;
        private System.Windows.Forms.ToolStripButton tsButtonImprimir;
        private System.Windows.Forms.ToolStrip toolStripConsulta;
        private System.Windows.Forms.ToolStripDropDownButton tsDDButtonFiltroF;
        private System.Windows.Forms.ToolStripMenuItem hoyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ultimos7DíasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ultimos30diasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ultimos60DíasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesActualToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtPickerHasta;
        private System.Windows.Forms.DateTimePicker dtPickerDesde;
        private System.Windows.Forms.CheckBox checkBoxFecha;
        private System.Windows.Forms.ToolStrip toolStripAccionesXMLOtros;
        private System.Windows.Forms.CheckBox checkBoxNDoc;
        private System.Windows.Forms.CheckBox checkBoxIdDoc;
        private System.Windows.Forms.ComboBox cmbBIdDoc;
        private System.Windows.Forms.ToolStrip tsConfirmaAnulaXml;
        private System.Windows.Forms.ToolStripLabel tsLabelConfirma;
        private System.Windows.Forms.ToolStripButton tsButtonConfirmaAnulaXml;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem genFacturaElectrónicaV10ToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxEstado;
        private System.Windows.Forms.ComboBox cmbBEstado;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox cmbBxCompannia;
        private System.Windows.Forms.ToolStripButton tsBtnAbrirXML;
        private System.Windows.Forms.ToolStripButton tsBtnAnulaElimina;
        private System.Windows.Forms.ToolStripButton tsBtnArchivoMensual;
        private System.Windows.Forms.ToolStrip toolStripPDF;
        private System.Windows.Forms.ToolStripButton tsBtnGeneraPDF;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip toolStripEmail;
        private System.Windows.Forms.ToolStripButton tsBtnEnviaEmail;
        private System.Windows.Forms.ToolStrip toolStripEmailMas;
        private System.Windows.Forms.ToolStripButton tsBtnConfiguraMsj;
        private System.Windows.Forms.ProgressBar pBarProcesoActivo;
        private System.Windows.Forms.CheckBox checkBoxMark;
        //        private System.Windows.Forms.DataGridViewTextBoxColumn cadenaOriginalDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox checkBoxCliente;
        private System.Windows.Forms.TextBox textBCliente;
        private System.Windows.Forms.ToolStripButton tsButtonConsultaTimbre;
        private System.Windows.Forms.ToolStripDropDownButton tsddButtonImprimir;
        private System.Windows.Forms.ToolStripTextBox tsTextDesde;
        private System.Windows.Forms.ToolStripTextBox tsTextHasta;
        private System.Windows.Forms.ToolStripMenuItem tsMenuImprimir;
        private System.Windows.Forms.ToolStripComboBox tsComboDestinoRep;
        private System.Windows.Forms.TabControl tabCfdi;
        private System.Windows.Forms.TabPage tabFacturas;
        private System.Windows.Forms.TabPage tabCobros;
        private System.Windows.Forms.ToolStripProgressBar tsPbProcesoActivo;
        private System.Windows.Forms.CheckBox cBoxMarcCobros;
        private System.Windows.Forms.DataGridView dgridTrxCobros;
        private System.Windows.Forms.DataGridViewCheckBoxColumn MarcaCobro;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soptype;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sopnumbe;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechahoraDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreClienteDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idImpuestoClienteDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mensajeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn mensajeEADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoActualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Isocurrc;
        private System.Windows.Forms.TabPage tabTraslados;
        private System.Windows.Forms.DataGridView dGridTraslados;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Mark;
        private System.Windows.Forms.DataGridViewTextBoxColumn Docid;
        private System.Windows.Forms.DataGridViewTextBoxColumn soptypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sopnumbeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechahoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idImpuestoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mensajeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoContabilizado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Voidstts;
        private System.Windows.Forms.DataGridViewTextBoxColumn MensajeEA;
        private System.Windows.Forms.DataGridViewTextBoxColumn eBinAct;
    }
}

