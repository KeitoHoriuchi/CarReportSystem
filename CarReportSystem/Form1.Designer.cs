namespace CarReportSystem
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbAuthor = new System.Windows.Forms.ComboBox();
            this.rbToyota = new System.Windows.Forms.RadioButton();
            this.rbNissan = new System.Windows.Forms.RadioButton();
            this.rbHonda = new System.Windows.Forms.RadioButton();
            this.rbSubaru = new System.Windows.Forms.RadioButton();
            this.rbGaisya = new System.Windows.Forms.RadioButton();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.btOpen = new System.Windows.Forms.Button();
            this.Maker = new System.Windows.Forms.GroupBox();
            this.btOpenImage = new System.Windows.Forms.Button();
            this.btDeleteImage = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btFix = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.ofdOpenImage = new System.Windows.Forms.OpenFileDialog();
            this.ofdOpenData = new System.Windows.Forms.OpenFileDialog();
            this.sfdSaveData = new System.Windows.Forms.SaveFileDialog();
            this.infosys202012DataSet = new CarReportSystem.infosys202012DataSet();
            this.carReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carReportTableAdapter = new CarReportSystem.infosys202012DataSetTableAdapters.CarReportTableAdapter();
            this.tableAdapterManager = new CarReportSystem.infosys202012DataSetTableAdapters.TableAdapterManager();
            this.carReportBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.carReportBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dgvRecode = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.tbReport = new System.Windows.Forms.TextBox();
            this.Maker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202012DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportBindingNavigator)).BeginInit();
            this.carReportBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecode)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(50, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "日付：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(34, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "記録者：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label3.Location = new System.Drawing.Point(34, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "メーカー：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label6.Location = new System.Drawing.Point(19, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "記事一覧：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label7.Location = new System.Drawing.Point(555, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "画像：";
            // 
            // cbAuthor
            // 
            this.cbAuthor.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.cbAuthor.FormattingEnabled = true;
            this.cbAuthor.Location = new System.Drawing.Point(122, 87);
            this.cbAuthor.Name = "cbAuthor";
            this.cbAuthor.Size = new System.Drawing.Size(200, 24);
            this.cbAuthor.TabIndex = 2;
            // 
            // rbToyota
            // 
            this.rbToyota.AutoSize = true;
            this.rbToyota.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.rbToyota.Location = new System.Drawing.Point(2, 4);
            this.rbToyota.Name = "rbToyota";
            this.rbToyota.Size = new System.Drawing.Size(58, 20);
            this.rbToyota.TabIndex = 3;
            this.rbToyota.TabStop = true;
            this.rbToyota.Tag = "0";
            this.rbToyota.Text = "トヨタ";
            this.rbToyota.UseVisualStyleBackColor = true;
            // 
            // rbNissan
            // 
            this.rbNissan.AutoSize = true;
            this.rbNissan.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.rbNissan.Location = new System.Drawing.Point(66, 4);
            this.rbNissan.Name = "rbNissan";
            this.rbNissan.Size = new System.Drawing.Size(58, 20);
            this.rbNissan.TabIndex = 3;
            this.rbNissan.TabStop = true;
            this.rbNissan.Tag = "1";
            this.rbNissan.Text = "日産";
            this.rbNissan.UseVisualStyleBackColor = true;
            // 
            // rbHonda
            // 
            this.rbHonda.AutoSize = true;
            this.rbHonda.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.rbHonda.Location = new System.Drawing.Point(130, 4);
            this.rbHonda.Name = "rbHonda";
            this.rbHonda.Size = new System.Drawing.Size(63, 20);
            this.rbHonda.TabIndex = 3;
            this.rbHonda.TabStop = true;
            this.rbHonda.Tag = "2";
            this.rbHonda.Text = "ホンダ";
            this.rbHonda.UseVisualStyleBackColor = true;
            // 
            // rbSubaru
            // 
            this.rbSubaru.AutoSize = true;
            this.rbSubaru.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.rbSubaru.Location = new System.Drawing.Point(199, 4);
            this.rbSubaru.Name = "rbSubaru";
            this.rbSubaru.Size = new System.Drawing.Size(65, 20);
            this.rbSubaru.TabIndex = 3;
            this.rbSubaru.TabStop = true;
            this.rbSubaru.Tag = "3";
            this.rbSubaru.Text = "スバル";
            this.rbSubaru.UseVisualStyleBackColor = true;
            // 
            // rbGaisya
            // 
            this.rbGaisya.AutoSize = true;
            this.rbGaisya.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.rbGaisya.Location = new System.Drawing.Point(270, 4);
            this.rbGaisya.Name = "rbGaisya";
            this.rbGaisya.Size = new System.Drawing.Size(58, 20);
            this.rbGaisya.TabIndex = 3;
            this.rbGaisya.TabStop = true;
            this.rbGaisya.Tag = "4";
            this.rbGaisya.Text = "外車";
            this.rbGaisya.UseVisualStyleBackColor = true;
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.rbOther.Location = new System.Drawing.Point(334, 4);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(67, 20);
            this.rbOther.TabIndex = 3;
            this.rbOther.TabStop = true;
            this.rbOther.Tag = "5";
            this.rbOther.Text = "その他";
            this.rbOther.UseVisualStyleBackColor = true;
            // 
            // cbName
            // 
            this.cbName.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(123, 154);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(201, 24);
            this.cbName.TabIndex = 4;
            // 
            // btOpen
            // 
            this.btOpen.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btOpen.Location = new System.Drawing.Point(20, 350);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(75, 23);
            this.btOpen.TabIndex = 7;
            this.btOpen.Text = "接続";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // Maker
            // 
            this.Maker.Controls.Add(this.rbHonda);
            this.Maker.Controls.Add(this.rbToyota);
            this.Maker.Controls.Add(this.rbNissan);
            this.Maker.Controls.Add(this.rbSubaru);
            this.Maker.Controls.Add(this.rbGaisya);
            this.Maker.Controls.Add(this.rbOther);
            this.Maker.Location = new System.Drawing.Point(121, 117);
            this.Maker.Name = "Maker";
            this.Maker.Size = new System.Drawing.Size(400, 29);
            this.Maker.TabIndex = 8;
            this.Maker.TabStop = false;
            // 
            // btOpenImage
            // 
            this.btOpenImage.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btOpenImage.Location = new System.Drawing.Point(609, 36);
            this.btOpenImage.Name = "btOpenImage";
            this.btOpenImage.Size = new System.Drawing.Size(75, 23);
            this.btOpenImage.TabIndex = 7;
            this.btOpenImage.Text = "開く";
            this.btOpenImage.UseVisualStyleBackColor = true;
            this.btOpenImage.Click += new System.EventHandler(this.btOpenImage_Click);
            // 
            // btDeleteImage
            // 
            this.btDeleteImage.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btDeleteImage.Location = new System.Drawing.Point(720, 36);
            this.btDeleteImage.Name = "btDeleteImage";
            this.btDeleteImage.Size = new System.Drawing.Size(75, 23);
            this.btDeleteImage.TabIndex = 7;
            this.btDeleteImage.Text = "削除";
            this.btDeleteImage.UseVisualStyleBackColor = true;
            this.btDeleteImage.Click += new System.EventHandler(this.btDeleteImage_Click);
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(558, 65);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(237, 198);
            this.pbImage.TabIndex = 9;
            this.pbImage.TabStop = false;
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btAdd.Location = new System.Drawing.Point(558, 290);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 7;
            this.btAdd.Text = "追加";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btFix
            // 
            this.btFix.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btFix.Location = new System.Drawing.Point(639, 290);
            this.btFix.Name = "btFix";
            this.btFix.Size = new System.Drawing.Size(75, 23);
            this.btFix.TabIndex = 7;
            this.btFix.Text = "修正";
            this.btFix.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            this.btDelete.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btDelete.Location = new System.Drawing.Point(720, 290);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 7;
            this.btDelete.Text = "削除";
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // ofdOpenImage
            // 
            this.ofdOpenImage.FileName = "openFileDialog1";
            // 
            // ofdOpenData
            // 
            this.ofdOpenData.FileName = "openFileDialog2";
            // 
            // infosys202012DataSet
            // 
            this.infosys202012DataSet.DataSetName = "infosys202012DataSet";
            this.infosys202012DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carReportBindingSource
            // 
            this.carReportBindingSource.DataMember = "CarReport";
            this.carReportBindingSource.DataSource = this.infosys202012DataSet;
            // 
            // carReportTableAdapter
            // 
            this.carReportTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarReportTableAdapter = this.carReportTableAdapter;
            this.tableAdapterManager.UpdateOrder = CarReportSystem.infosys202012DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // carReportBindingNavigator
            // 
            this.carReportBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.carReportBindingNavigator.BindingSource = this.carReportBindingSource;
            this.carReportBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.carReportBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.carReportBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.carReportBindingNavigatorSaveItem});
            this.carReportBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.carReportBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.carReportBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.carReportBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.carReportBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.carReportBindingNavigator.Name = "carReportBindingNavigator";
            this.carReportBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.carReportBindingNavigator.Size = new System.Drawing.Size(902, 25);
            this.carReportBindingNavigator.TabIndex = 10;
            this.carReportBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "新規追加";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目の総数";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "削除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "最初に移動";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "前に戻る";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "現在の場所";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "次に移動";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "最後に移動";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // carReportBindingNavigatorSaveItem
            // 
            this.carReportBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.carReportBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("carReportBindingNavigatorSaveItem.Image")));
            this.carReportBindingNavigatorSaveItem.Name = "carReportBindingNavigatorSaveItem";
            this.carReportBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.carReportBindingNavigatorSaveItem.Text = "データの保存";
            this.carReportBindingNavigatorSaveItem.Click += new System.EventHandler(this.carReportBindingNavigatorSaveItem_Click);
            // 
            // dgvRecode
            // 
            this.dgvRecode.AutoGenerateColumns = false;
            this.dgvRecode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecode.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewImageColumn1});
            this.dgvRecode.DataSource = this.carReportBindingSource;
            this.dgvRecode.Location = new System.Drawing.Point(123, 319);
            this.dgvRecode.MultiSelect = false;
            this.dgvRecode.Name = "dgvRecode";
            this.dgvRecode.RowTemplate.Height = 21;
            this.dgvRecode.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecode.Size = new System.Drawing.Size(743, 220);
            this.dgvRecode.TabIndex = 20;
            this.dgvRecode.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecode_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CreatedDate";
            this.dataGridViewTextBoxColumn2.HeaderText = "CreatedDate";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Author";
            this.dataGridViewTextBoxColumn3.HeaderText = "Author";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Maker";
            this.dataGridViewTextBoxColumn4.HeaderText = "Maker";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn5.HeaderText = "Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Report";
            this.dataGridViewTextBoxColumn6.HeaderText = "Report";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Picture";
            this.dataGridViewImageColumn1.HeaderText = "Picture";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label4.Location = new System.Drawing.Point(50, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "車名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label5.Location = new System.Drawing.Point(34, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "レポート：";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.dtpDate.Location = new System.Drawing.Point(121, 39);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 23);
            this.dtpDate.TabIndex = 1;
            // 
            // tbReport
            // 
            this.tbReport.Location = new System.Drawing.Point(123, 197);
            this.tbReport.Multiline = true;
            this.tbReport.Name = "tbReport";
            this.tbReport.Size = new System.Drawing.Size(406, 115);
            this.tbReport.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 575);
            this.Controls.Add(this.dgvRecode);
            this.Controls.Add(this.carReportBindingNavigator);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.Maker);
            this.Controls.Add(this.btDeleteImage);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btFix);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btOpenImage);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.tbReport);
            this.Controls.Add(this.cbName);
            this.Controls.Add(this.cbAuthor);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "試乗レポート管理システム";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Maker.ResumeLayout(false);
            this.Maker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202012DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportBindingNavigator)).EndInit();
            this.carReportBindingNavigator.ResumeLayout(false);
            this.carReportBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbAuthor;
        private System.Windows.Forms.RadioButton rbToyota;
        private System.Windows.Forms.RadioButton rbNissan;
        private System.Windows.Forms.RadioButton rbHonda;
        private System.Windows.Forms.RadioButton rbSubaru;
        private System.Windows.Forms.RadioButton rbGaisya;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.ComboBox cbName;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.GroupBox Maker;
        private System.Windows.Forms.Button btOpenImage;
        private System.Windows.Forms.Button btDeleteImage;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btFix;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.OpenFileDialog ofdOpenImage;
        private System.Windows.Forms.OpenFileDialog ofdOpenData;
        private System.Windows.Forms.SaveFileDialog sfdSaveData;
        private infosys202012DataSet infosys202012DataSet;
        private System.Windows.Forms.BindingSource carReportBindingSource;
        private infosys202012DataSetTableAdapters.CarReportTableAdapter carReportTableAdapter;
        private infosys202012DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator carReportBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton carReportBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dgvRecode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox tbReport;
    }
}

