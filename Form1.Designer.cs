namespace ADO.NET_1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labDatSource = new System.Windows.Forms.Label();
            this.labInitCat = new System.Windows.Forms.Label();
            this.tbDatSource = new System.Windows.Forms.TextBox();
            this.tbInitCat = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.datGridDBTables = new System.Windows.Forms.DataGridView();
            this.labSQLReq = new System.Windows.Forms.Label();
            this.tbRequest = new System.Windows.Forms.TextBox();
            this.btnRequest = new System.Windows.Forms.Button();
            this.datGridSQLResult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datGridDBTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datGridSQLResult)).BeginInit();
            this.SuspendLayout();
            // 
            // labDatSource
            // 
            this.labDatSource.AutoSize = true;
            this.labDatSource.Location = new System.Drawing.Point(26, 22);
            this.labDatSource.Name = "labDatSource";
            this.labDatSource.Size = new System.Drawing.Size(87, 17);
            this.labDatSource.TabIndex = 0;
            this.labDatSource.Text = "Data Sourse";
            // 
            // labInitCat
            // 
            this.labInitCat.AutoSize = true;
            this.labInitCat.Location = new System.Drawing.Point(26, 58);
            this.labInitCat.Name = "labInitCat";
            this.labInitCat.Size = new System.Drawing.Size(92, 17);
            this.labInitCat.TabIndex = 1;
            this.labInitCat.Text = "Initial Catalog";
            // 
            // tbDatSource
            // 
            this.tbDatSource.Location = new System.Drawing.Point(131, 22);
            this.tbDatSource.Name = "tbDatSource";
            this.tbDatSource.Size = new System.Drawing.Size(488, 22);
            this.tbDatSource.TabIndex = 2;
            // 
            // tbInitCat
            // 
            this.tbInitCat.Location = new System.Drawing.Point(131, 58);
            this.tbInitCat.Name = "tbInitCat";
            this.tbInitCat.Size = new System.Drawing.Size(352, 22);
            this.tbInitCat.TabIndex = 3;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(509, 58);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(110, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect to DB";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // datGridDBTables
            // 
            this.datGridDBTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datGridDBTables.Location = new System.Drawing.Point(29, 87);
            this.datGridDBTables.Name = "datGridDBTables";
            this.datGridDBTables.RowHeadersWidth = 51;
            this.datGridDBTables.RowTemplate.Height = 24;
            this.datGridDBTables.Size = new System.Drawing.Size(590, 150);
            this.datGridDBTables.TabIndex = 5;
            // 
            // labSQLReq
            // 
            this.labSQLReq.AutoSize = true;
            this.labSQLReq.Location = new System.Drawing.Point(26, 253);
            this.labSQLReq.Name = "labSQLReq";
            this.labSQLReq.Size = new System.Drawing.Size(93, 17);
            this.labSQLReq.TabIndex = 6;
            this.labSQLReq.Text = "SQL Request";
            // 
            // tbRequest
            // 
            this.tbRequest.Location = new System.Drawing.Point(131, 250);
            this.tbRequest.Name = "tbRequest";
            this.tbRequest.Size = new System.Drawing.Size(352, 22);
            this.tbRequest.TabIndex = 7;
            // 
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(509, 249);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(110, 23);
            this.btnRequest.TabIndex = 8;
            this.btnRequest.Text = "Send Request";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // datGridSQLResult
            // 
            this.datGridSQLResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datGridSQLResult.Location = new System.Drawing.Point(29, 278);
            this.datGridSQLResult.Name = "datGridSQLResult";
            this.datGridSQLResult.RowHeadersWidth = 51;
            this.datGridSQLResult.RowTemplate.Height = 24;
            this.datGridSQLResult.Size = new System.Drawing.Size(590, 150);
            this.datGridSQLResult.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 464);
            this.Controls.Add(this.datGridSQLResult);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.tbRequest);
            this.Controls.Add(this.labSQLReq);
            this.Controls.Add(this.datGridDBTables);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tbInitCat);
            this.Controls.Add(this.tbDatSource);
            this.Controls.Add(this.labInitCat);
            this.Controls.Add(this.labDatSource);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datGridDBTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datGridSQLResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labDatSource;
        private System.Windows.Forms.Label labInitCat;
        private System.Windows.Forms.TextBox tbDatSource;
        private System.Windows.Forms.TextBox tbInitCat;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.DataGridView datGridDBTables;
        private System.Windows.Forms.Label labSQLReq;
        private System.Windows.Forms.TextBox tbRequest;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.DataGridView datGridSQLResult;
    }
}

