namespace Magazyn1._0
{
    partial class Form1
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nazwaLabel;
            System.Windows.Forms.Label producentLabel;
            System.Windows.Forms.Label alejaLabel;
            System.Windows.Forms.Label boxLabel;
            System.Windows.Forms.Label pozycjaLabel;
            System.Windows.Forms.Label ilośćLabel;
            System.Windows.Forms.Label typLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label rozmiarLabel;
            this.addBtn = new MetroFramework.Controls.MetroTile();
            this.deleteBtn = new MetroFramework.Controls.MetroTile();
            this.selectAllBtn = new MetroFramework.Controls.MetroTile();
            this.raportBtn = new MetroFramework.Controls.MetroTile();
            this.moreBtn = new MetroFramework.Controls.MetroTile();
            this.productDataGrid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magazynDataSet = new Magazyn1._0.MagazynDataSet();
            this.tableTableAdapter = new Magazyn1._0.MagazynDataSetTableAdapters.TableTableAdapter();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nazwaTextBox = new System.Windows.Forms.TextBox();
            this.producentTextBox = new System.Windows.Forms.TextBox();
            this.alejaTextBox = new System.Windows.Forms.TextBox();
            this.boxTextBox = new System.Windows.Forms.TextBox();
            this.pozycjaTextBox = new System.Windows.Forms.TextBox();
            this.ilośćTextBox = new System.Windows.Forms.TextBox();
            this.typTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.rozmiarTextBox = new System.Windows.Forms.TextBox();
            this.magazynDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idLabel = new System.Windows.Forms.Label();
            nazwaLabel = new System.Windows.Forms.Label();
            producentLabel = new System.Windows.Forms.Label();
            alejaLabel = new System.Windows.Forms.Label();
            boxLabel = new System.Windows.Forms.Label();
            pozycjaLabel = new System.Windows.Forms.Label();
            ilośćLabel = new System.Windows.Forms.Label();
            typLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            rozmiarLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazynDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazynDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(685, 38);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 6;
            idLabel.Text = "Id:";
            // 
            // nazwaLabel
            // 
            nazwaLabel.AutoSize = true;
            nazwaLabel.Location = new System.Drawing.Point(661, 64);
            nazwaLabel.Name = "nazwaLabel";
            nazwaLabel.Size = new System.Drawing.Size(43, 13);
            nazwaLabel.TabIndex = 8;
            nazwaLabel.Text = "Nazwa:";
            // 
            // producentLabel
            // 
            producentLabel.AutoSize = true;
            producentLabel.Location = new System.Drawing.Point(645, 90);
            producentLabel.Name = "producentLabel";
            producentLabel.Size = new System.Drawing.Size(59, 13);
            producentLabel.TabIndex = 10;
            producentLabel.Text = "Producent:";
            // 
            // alejaLabel
            // 
            alejaLabel.AutoSize = true;
            alejaLabel.Location = new System.Drawing.Point(671, 116);
            alejaLabel.Name = "alejaLabel";
            alejaLabel.Size = new System.Drawing.Size(33, 13);
            alejaLabel.TabIndex = 12;
            alejaLabel.Text = "Aleja:";
            // 
            // boxLabel
            // 
            boxLabel.AutoSize = true;
            boxLabel.Location = new System.Drawing.Point(676, 142);
            boxLabel.Name = "boxLabel";
            boxLabel.Size = new System.Drawing.Size(28, 13);
            boxLabel.TabIndex = 14;
            boxLabel.Text = "Box:";
            // 
            // pozycjaLabel
            // 
            pozycjaLabel.AutoSize = true;
            pozycjaLabel.Location = new System.Drawing.Point(657, 168);
            pozycjaLabel.Name = "pozycjaLabel";
            pozycjaLabel.Size = new System.Drawing.Size(47, 13);
            pozycjaLabel.TabIndex = 16;
            pozycjaLabel.Text = "Pozycja:";
            // 
            // ilośćLabel
            // 
            ilośćLabel.AutoSize = true;
            ilośćLabel.Location = new System.Drawing.Point(672, 194);
            ilośćLabel.Name = "ilośćLabel";
            ilośćLabel.Size = new System.Drawing.Size(32, 13);
            ilośćLabel.TabIndex = 18;
            ilośćLabel.Text = "Ilość:";
            // 
            // typLabel
            // 
            typLabel.AutoSize = true;
            typLabel.Location = new System.Drawing.Point(676, 220);
            typLabel.Name = "typLabel";
            typLabel.Size = new System.Drawing.Size(28, 13);
            typLabel.TabIndex = 20;
            typLabel.Text = "Typ:";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new System.Drawing.Point(665, 249);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(39, 13);
            modelLabel.TabIndex = 22;
            modelLabel.Text = "Model:";
            // 
            // rozmiarLabel
            // 
            rozmiarLabel.AutoSize = true;
            rozmiarLabel.Location = new System.Drawing.Point(656, 275);
            rozmiarLabel.Name = "rozmiarLabel";
            rozmiarLabel.Size = new System.Drawing.Size(48, 13);
            rozmiarLabel.TabIndex = 24;
            rozmiarLabel.Text = "Rozmiar:";
            // 
            // addBtn
            // 
            this.addBtn.ActiveControl = null;
            this.addBtn.Location = new System.Drawing.Point(23, 63);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(70, 70);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Dodaj";
            this.addBtn.TileImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.addBtn.UseSelectable = true;
            this.addBtn.UseTileImage = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.ActiveControl = null;
            this.deleteBtn.Location = new System.Drawing.Point(100, 64);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(70, 70);
            this.deleteBtn.TabIndex = 1;
            this.deleteBtn.Text = "Usuń";
            this.deleteBtn.UseSelectable = true;
            // 
            // selectAllBtn
            // 
            this.selectAllBtn.ActiveControl = null;
            this.selectAllBtn.Location = new System.Drawing.Point(23, 140);
            this.selectAllBtn.Name = "selectAllBtn";
            this.selectAllBtn.Size = new System.Drawing.Size(147, 70);
            this.selectAllBtn.TabIndex = 2;
            this.selectAllBtn.Text = "Zaznacz wszystko";
            this.selectAllBtn.UseSelectable = true;
            // 
            // raportBtn
            // 
            this.raportBtn.ActiveControl = null;
            this.raportBtn.Location = new System.Drawing.Point(23, 217);
            this.raportBtn.Name = "raportBtn";
            this.raportBtn.Size = new System.Drawing.Size(70, 70);
            this.raportBtn.TabIndex = 3;
            this.raportBtn.Text = "Raport";
            this.raportBtn.UseSelectable = true;
            // 
            // moreBtn
            // 
            this.moreBtn.ActiveControl = null;
            this.moreBtn.Location = new System.Drawing.Point(100, 217);
            this.moreBtn.Name = "moreBtn";
            this.moreBtn.Size = new System.Drawing.Size(70, 70);
            this.moreBtn.TabIndex = 4;
            this.moreBtn.Text = "Więcej";
            this.moreBtn.UseSelectable = true;
            this.moreBtn.Click += new System.EventHandler(this.moreBtn_Click);
            // 
            // productDataGrid
            // 
            this.productDataGrid.AllowUserToDeleteRows = false;
            this.productDataGrid.AutoGenerateColumns = false;
            this.productDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.producentDataGridViewTextBoxColumn,
            this.nazwaDataGridViewTextBoxColumn,
            this.typDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn});
            this.productDataGrid.DataSource = this.tableBindingSource;
            this.productDataGrid.Location = new System.Drawing.Point(177, 63);
            this.productDataGrid.Name = "productDataGrid";
            this.productDataGrid.ReadOnly = true;
            this.productDataGrid.Size = new System.Drawing.Size(443, 224);
            this.productDataGrid.TabIndex = 5;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.magazynDataSet;
            // 
            // magazynDataSet
            // 
            this.magazynDataSet.DataSetName = "MagazynDataSet";
            this.magazynDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(710, 35);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 7;
            // 
            // nazwaTextBox
            // 
            this.nazwaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Nazwa", true));
            this.nazwaTextBox.Location = new System.Drawing.Point(710, 61);
            this.nazwaTextBox.Name = "nazwaTextBox";
            this.nazwaTextBox.Size = new System.Drawing.Size(100, 20);
            this.nazwaTextBox.TabIndex = 9;
            // 
            // producentTextBox
            // 
            this.producentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Producent", true));
            this.producentTextBox.Location = new System.Drawing.Point(710, 87);
            this.producentTextBox.Name = "producentTextBox";
            this.producentTextBox.Size = new System.Drawing.Size(100, 20);
            this.producentTextBox.TabIndex = 11;
            // 
            // alejaTextBox
            // 
            this.alejaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Aleja", true));
            this.alejaTextBox.Location = new System.Drawing.Point(710, 113);
            this.alejaTextBox.Name = "alejaTextBox";
            this.alejaTextBox.Size = new System.Drawing.Size(100, 20);
            this.alejaTextBox.TabIndex = 13;
            // 
            // boxTextBox
            // 
            this.boxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Box", true));
            this.boxTextBox.Location = new System.Drawing.Point(710, 139);
            this.boxTextBox.Name = "boxTextBox";
            this.boxTextBox.Size = new System.Drawing.Size(100, 20);
            this.boxTextBox.TabIndex = 15;
            // 
            // pozycjaTextBox
            // 
            this.pozycjaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Pozycja", true));
            this.pozycjaTextBox.Location = new System.Drawing.Point(710, 165);
            this.pozycjaTextBox.Name = "pozycjaTextBox";
            this.pozycjaTextBox.Size = new System.Drawing.Size(100, 20);
            this.pozycjaTextBox.TabIndex = 17;
            // 
            // ilośćTextBox
            // 
            this.ilośćTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Ilość", true));
            this.ilośćTextBox.Location = new System.Drawing.Point(710, 191);
            this.ilośćTextBox.Name = "ilośćTextBox";
            this.ilośćTextBox.Size = new System.Drawing.Size(100, 20);
            this.ilośćTextBox.TabIndex = 19;
            // 
            // typTextBox
            // 
            this.typTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Typ", true));
            this.typTextBox.Location = new System.Drawing.Point(710, 217);
            this.typTextBox.Name = "typTextBox";
            this.typTextBox.Size = new System.Drawing.Size(100, 20);
            this.typTextBox.TabIndex = 21;
            // 
            // modelTextBox
            // 
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Model", true));
            this.modelTextBox.Location = new System.Drawing.Point(710, 246);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(100, 20);
            this.modelTextBox.TabIndex = 23;
            // 
            // rozmiarTextBox
            // 
            this.rozmiarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Rozmiar", true));
            this.rozmiarTextBox.Location = new System.Drawing.Point(710, 272);
            this.rozmiarTextBox.Name = "rozmiarTextBox";
            this.rozmiarTextBox.Size = new System.Drawing.Size(100, 20);
            this.rozmiarTextBox.TabIndex = 25;
            // 
            // magazynDataSetBindingSource
            // 
            this.magazynDataSetBindingSource.DataSource = this.magazynDataSet;
            this.magazynDataSetBindingSource.Position = 0;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typDataGridViewTextBoxColumn
            // 
            this.typDataGridViewTextBoxColumn.DataPropertyName = "Typ";
            this.typDataGridViewTextBoxColumn.HeaderText = "Typ";
            this.typDataGridViewTextBoxColumn.Name = "typDataGridViewTextBoxColumn";
            this.typDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazwaDataGridViewTextBoxColumn
            // 
            this.nazwaDataGridViewTextBoxColumn.DataPropertyName = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.HeaderText = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.Name = "nazwaDataGridViewTextBoxColumn";
            this.nazwaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // producentDataGridViewTextBoxColumn
            // 
            this.producentDataGridViewTextBoxColumn.DataPropertyName = "Producent";
            this.producentDataGridViewTextBoxColumn.HeaderText = "Producent";
            this.producentDataGridViewTextBoxColumn.Name = "producentDataGridViewTextBoxColumn";
            this.producentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 328);
            this.Controls.Add(rozmiarLabel);
            this.Controls.Add(this.rozmiarTextBox);
            this.Controls.Add(modelLabel);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(typLabel);
            this.Controls.Add(this.typTextBox);
            this.Controls.Add(ilośćLabel);
            this.Controls.Add(this.ilośćTextBox);
            this.Controls.Add(pozycjaLabel);
            this.Controls.Add(this.pozycjaTextBox);
            this.Controls.Add(boxLabel);
            this.Controls.Add(this.boxTextBox);
            this.Controls.Add(alejaLabel);
            this.Controls.Add(this.alejaTextBox);
            this.Controls.Add(producentLabel);
            this.Controls.Add(this.producentTextBox);
            this.Controls.Add(nazwaLabel);
            this.Controls.Add(this.nazwaTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.productDataGrid);
            this.Controls.Add(this.moreBtn);
            this.Controls.Add(this.raportBtn);
            this.Controls.Add(this.selectAllBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "Magazyn1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazynDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazynDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile addBtn;
        private MetroFramework.Controls.MetroTile deleteBtn;
        private MetroFramework.Controls.MetroTile selectAllBtn;
        private MetroFramework.Controls.MetroTile raportBtn;
        private MetroFramework.Controls.MetroTile moreBtn;
        private System.Windows.Forms.DataGridView productDataGrid;
        private MagazynDataSet magazynDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private MagazynDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nazwaTextBox;
        private System.Windows.Forms.TextBox producentTextBox;
        private System.Windows.Forms.TextBox alejaTextBox;
        private System.Windows.Forms.TextBox boxTextBox;
        private System.Windows.Forms.TextBox pozycjaTextBox;
        private System.Windows.Forms.TextBox ilośćTextBox;
        private System.Windows.Forms.TextBox typTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox rozmiarTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn producentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource magazynDataSetBindingSource;
    }
}

