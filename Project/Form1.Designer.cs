
namespace Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label iD_ActorLabel;
            System.Windows.Forms.Label prenumeLabel;
            System.Windows.Forms.Label numeLabel;
            System.Windows.Forms.Label data_NasteriiLabel;
            System.Windows.Forms.Label tara_de_OrigineLabel;
            this.databaseDataSet = new Project.DatabaseDataSet();
            this.actoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actoriTableAdapter = new Project.DatabaseDataSetTableAdapters.ActoriTableAdapter();
            this.tableAdapterManager = new Project.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.actoriBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.actoriBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_ActorTextBox = new System.Windows.Forms.TextBox();
            this.prenumeTextBox = new System.Windows.Forms.TextBox();
            this.numeTextBox = new System.Windows.Forms.TextBox();
            this.data_NasteriiDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tara_de_OrigineTextBox = new System.Windows.Forms.TextBox();
            iD_ActorLabel = new System.Windows.Forms.Label();
            prenumeLabel = new System.Windows.Forms.Label();
            numeLabel = new System.Windows.Forms.Label();
            data_NasteriiLabel = new System.Windows.Forms.Label();
            tara_de_OrigineLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actoriBindingNavigator)).BeginInit();
            this.actoriBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // actoriBindingSource
            // 
            this.actoriBindingSource.DataMember = "Actori";
            this.actoriBindingSource.DataSource = this.databaseDataSet;
            // 
            // actoriTableAdapter
            // 
            this.actoriTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActoriTableAdapter = this.actoriTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FilmeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Project.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // actoriBindingNavigator
            // 
            this.actoriBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.actoriBindingNavigator.BindingSource = this.actoriBindingSource;
            this.actoriBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.actoriBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.actoriBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.actoriBindingNavigatorSaveItem});
            this.actoriBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.actoriBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.actoriBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.actoriBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.actoriBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.actoriBindingNavigator.Name = "actoriBindingNavigator";
            this.actoriBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.actoriBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.actoriBindingNavigator.TabIndex = 0;
            this.actoriBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // actoriBindingNavigatorSaveItem
            // 
            this.actoriBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.actoriBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("actoriBindingNavigatorSaveItem.Image")));
            this.actoriBindingNavigatorSaveItem.Name = "actoriBindingNavigatorSaveItem";
            this.actoriBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.actoriBindingNavigatorSaveItem.Text = "Save Data";
            this.actoriBindingNavigatorSaveItem.Click += new System.EventHandler(this.actoriBindingNavigatorSaveItem_Click);
            // 
            // iD_ActorLabel
            // 
            iD_ActorLabel.AutoSize = true;
            iD_ActorLabel.Location = new System.Drawing.Point(251, 131);
            iD_ActorLabel.Name = "iD_ActorLabel";
            iD_ActorLabel.Size = new System.Drawing.Size(49, 13);
            iD_ActorLabel.TabIndex = 1;
            iD_ActorLabel.Text = "ID Actor:";
            // 
            // iD_ActorTextBox
            // 
            this.iD_ActorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.actoriBindingSource, "ID_Actor", true));
            this.iD_ActorTextBox.Location = new System.Drawing.Point(340, 128);
            this.iD_ActorTextBox.Name = "iD_ActorTextBox";
            this.iD_ActorTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_ActorTextBox.TabIndex = 2;
            // 
            // prenumeLabel
            // 
            prenumeLabel.AutoSize = true;
            prenumeLabel.Location = new System.Drawing.Point(251, 157);
            prenumeLabel.Name = "prenumeLabel";
            prenumeLabel.Size = new System.Drawing.Size(52, 13);
            prenumeLabel.TabIndex = 3;
            prenumeLabel.Text = "Prenume:";
            // 
            // prenumeTextBox
            // 
            this.prenumeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.actoriBindingSource, "Prenume", true));
            this.prenumeTextBox.Location = new System.Drawing.Point(340, 154);
            this.prenumeTextBox.Name = "prenumeTextBox";
            this.prenumeTextBox.Size = new System.Drawing.Size(200, 20);
            this.prenumeTextBox.TabIndex = 4;
            // 
            // numeLabel
            // 
            numeLabel.AutoSize = true;
            numeLabel.Location = new System.Drawing.Point(251, 183);
            numeLabel.Name = "numeLabel";
            numeLabel.Size = new System.Drawing.Size(38, 13);
            numeLabel.TabIndex = 5;
            numeLabel.Text = "Nume:";
            // 
            // numeTextBox
            // 
            this.numeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.actoriBindingSource, "Nume", true));
            this.numeTextBox.Location = new System.Drawing.Point(340, 180);
            this.numeTextBox.Name = "numeTextBox";
            this.numeTextBox.Size = new System.Drawing.Size(200, 20);
            this.numeTextBox.TabIndex = 6;
            // 
            // data_NasteriiLabel
            // 
            data_NasteriiLabel.AutoSize = true;
            data_NasteriiLabel.Location = new System.Drawing.Point(251, 210);
            data_NasteriiLabel.Name = "data_NasteriiLabel";
            data_NasteriiLabel.Size = new System.Drawing.Size(71, 13);
            data_NasteriiLabel.TabIndex = 7;
            data_NasteriiLabel.Text = "Data Nasterii:";
            // 
            // data_NasteriiDateTimePicker
            // 
            this.data_NasteriiDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.actoriBindingSource, "Data Nasterii", true));
            this.data_NasteriiDateTimePicker.Location = new System.Drawing.Point(340, 206);
            this.data_NasteriiDateTimePicker.Name = "data_NasteriiDateTimePicker";
            this.data_NasteriiDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.data_NasteriiDateTimePicker.TabIndex = 8;
            // 
            // tara_de_OrigineLabel
            // 
            tara_de_OrigineLabel.AutoSize = true;
            tara_de_OrigineLabel.Location = new System.Drawing.Point(251, 235);
            tara_de_OrigineLabel.Name = "tara_de_OrigineLabel";
            tara_de_OrigineLabel.Size = new System.Drawing.Size(83, 13);
            tara_de_OrigineLabel.TabIndex = 9;
            tara_de_OrigineLabel.Text = "Tara de Origine:";
            // 
            // tara_de_OrigineTextBox
            // 
            this.tara_de_OrigineTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.actoriBindingSource, "Tara de Origine", true));
            this.tara_de_OrigineTextBox.Location = new System.Drawing.Point(340, 232);
            this.tara_de_OrigineTextBox.Name = "tara_de_OrigineTextBox";
            this.tara_de_OrigineTextBox.Size = new System.Drawing.Size(200, 20);
            this.tara_de_OrigineTextBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(iD_ActorLabel);
            this.Controls.Add(this.iD_ActorTextBox);
            this.Controls.Add(prenumeLabel);
            this.Controls.Add(this.prenumeTextBox);
            this.Controls.Add(numeLabel);
            this.Controls.Add(this.numeTextBox);
            this.Controls.Add(data_NasteriiLabel);
            this.Controls.Add(this.data_NasteriiDateTimePicker);
            this.Controls.Add(tara_de_OrigineLabel);
            this.Controls.Add(this.tara_de_OrigineTextBox);
            this.Controls.Add(this.actoriBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actoriBindingNavigator)).EndInit();
            this.actoriBindingNavigator.ResumeLayout(false);
            this.actoriBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource actoriBindingSource;
        private DatabaseDataSetTableAdapters.ActoriTableAdapter actoriTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator actoriBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton actoriBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_ActorTextBox;
        private System.Windows.Forms.TextBox prenumeTextBox;
        private System.Windows.Forms.TextBox numeTextBox;
        private System.Windows.Forms.DateTimePicker data_NasteriiDateTimePicker;
        private System.Windows.Forms.TextBox tara_de_OrigineTextBox;
    }
}