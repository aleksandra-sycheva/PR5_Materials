namespace PR5_Materials
{
    partial class Form1
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
            panelTop = new Panel();
            buttonCreate = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            buttonHistoryOfSuppliers = new Button();
            panelFill = new Panel();
            dataGridViewSuppliers = new DataGridView();
            panelTop.SuspendLayout();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuppliers).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(buttonHistoryOfSuppliers);
            panelTop.Controls.Add(buttonDelete);
            panelTop.Controls.Add(buttonUpdate);
            panelTop.Controls.Add(buttonCreate);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(919, 125);
            panelTop.TabIndex = 0;
            // 
            // buttonCreate
            // 
            buttonCreate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCreate.Location = new Point(12, 23);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(162, 82);
            buttonCreate.TabIndex = 0;
            buttonCreate.Text = "Добавить";
            buttonCreate.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonUpdate.Location = new Point(197, 23);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(203, 82);
            buttonUpdate.TabIndex = 1;
            buttonUpdate.Text = "Редактировать";
            buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            buttonDelete.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDelete.Location = new Point(422, 23);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(162, 82);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonHistoryOfSuppliers
            // 
            buttonHistoryOfSuppliers.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonHistoryOfSuppliers.Location = new Point(607, 23);
            buttonHistoryOfSuppliers.Name = "buttonHistoryOfSuppliers";
            buttonHistoryOfSuppliers.Size = new Size(296, 82);
            buttonHistoryOfSuppliers.TabIndex = 3;
            buttonHistoryOfSuppliers.Text = "История поставок";
            buttonHistoryOfSuppliers.UseVisualStyleBackColor = true;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(dataGridViewSuppliers);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 125);
            panelFill.Name = "panelFill";
            panelFill.Size = new Size(919, 498);
            panelFill.TabIndex = 1;
            // 
            // dataGridViewSuppliers
            // 
            dataGridViewSuppliers.BackgroundColor = Color.White;
            dataGridViewSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSuppliers.Dock = DockStyle.Fill;
            dataGridViewSuppliers.Location = new Point(0, 0);
            dataGridViewSuppliers.Name = "dataGridViewSuppliers";
            dataGridViewSuppliers.RowHeadersWidth = 51;
            dataGridViewSuppliers.Size = new Size(919, 498);
            dataGridViewSuppliers.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 623);
            Controls.Add(panelFill);
            Controls.Add(panelTop);
            Name = "Form1";
            Text = "Form1";
            panelTop.ResumeLayout(false);
            panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuppliers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Button buttonHistoryOfSuppliers;
        private Button buttonDelete;
        private Button buttonUpdate;
        private Button buttonCreate;
        private Panel panelFill;
        private DataGridView dataGridViewSuppliers;
    }
}
