namespace HamiltonianPathGui
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gViewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            this.addNodeLabel = new System.Windows.Forms.Label();
            this.addNodeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.addNodeButton = new System.Windows.Forms.Button();
            this.addEdgeFromNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.addEdgeFromLabel = new System.Windows.Forms.Label();
            this.addEdgeToNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.addEdgeToLabel = new System.Windows.Forms.Label();
            this.addEdgeButton = new System.Windows.Forms.Button();
            this.findHamiltonianPathButton = new System.Windows.Forms.Button();
            this.hamiltonianPathLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.addNodeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addEdgeFromNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addEdgeToNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // gViewer
            // 
            this.gViewer.ArrowheadLength = 10D;
            this.gViewer.AsyncLayout = false;
            this.gViewer.AutoScroll = true;
            this.gViewer.BackwardEnabled = false;
            this.gViewer.BuildHitTree = true;
            this.gViewer.CurrentLayoutMethod = Microsoft.Msagl.GraphViewerGdi.LayoutMethod.UseSettingsOfTheGraph;
            this.gViewer.EdgeInsertButtonVisible = true;
            this.gViewer.FileName = "";
            this.gViewer.ForwardEnabled = false;
            this.gViewer.Graph = null;
            this.gViewer.InsertingEdge = false;
            this.gViewer.LayoutAlgorithmSettingsButtonVisible = true;
            this.gViewer.LayoutEditingEnabled = true;
            this.gViewer.Location = new System.Drawing.Point(12, 12);
            this.gViewer.LooseOffsetForRouting = 0.25D;
            this.gViewer.MouseHitDistance = 0.05D;
            this.gViewer.Name = "gViewer";
            this.gViewer.NavigationVisible = true;
            this.gViewer.NeedToCalculateLayout = true;
            this.gViewer.OffsetForRelaxingInRouting = 0.6D;
            this.gViewer.PaddingForEdgeRouting = 8D;
            this.gViewer.PanButtonPressed = false;
            this.gViewer.SaveAsImageEnabled = true;
            this.gViewer.SaveAsMsaglEnabled = true;
            this.gViewer.SaveButtonVisible = true;
            this.gViewer.SaveGraphButtonVisible = true;
            this.gViewer.SaveInVectorFormatEnabled = true;
            this.gViewer.Size = new System.Drawing.Size(737, 637);
            this.gViewer.TabIndex = 0;
            this.gViewer.TightOffsetForRouting = 0.125D;
            this.gViewer.ToolBarIsVisible = true;
            this.gViewer.Transform = ((Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation)(resources.GetObject("gViewer.Transform")));
            this.gViewer.UndoRedoButtonsVisible = true;
            this.gViewer.WindowZoomButtonPressed = false;
            this.gViewer.ZoomF = 1D;
            this.gViewer.ZoomWindowThreshold = 0.05D;
            // 
            // addNodeLabel
            // 
            this.addNodeLabel.AutoSize = true;
            this.addNodeLabel.Location = new System.Drawing.Point(755, 12);
            this.addNodeLabel.Name = "addNodeLabel";
            this.addNodeLabel.Size = new System.Drawing.Size(62, 15);
            this.addNodeLabel.TabIndex = 1;
            this.addNodeLabel.Text = "Add node:";
            // 
            // addNodeNumericUpDown
            // 
            this.addNodeNumericUpDown.Location = new System.Drawing.Point(755, 30);
            this.addNodeNumericUpDown.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.addNodeNumericUpDown.Name = "addNodeNumericUpDown";
            this.addNodeNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.addNodeNumericUpDown.TabIndex = 2;
            this.addNodeNumericUpDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addNodeNumericUpDown_KeyPress);
            // 
            // addNodeButton
            // 
            this.addNodeButton.Location = new System.Drawing.Point(881, 30);
            this.addNodeButton.Name = "addNodeButton";
            this.addNodeButton.Size = new System.Drawing.Size(75, 23);
            this.addNodeButton.TabIndex = 3;
            this.addNodeButton.Text = "Add node";
            this.addNodeButton.UseVisualStyleBackColor = true;
            this.addNodeButton.Click += new System.EventHandler(this.addNodeButton_Click);
            // 
            // addEdgeFromNumericUpDown
            // 
            this.addEdgeFromNumericUpDown.Location = new System.Drawing.Point(755, 119);
            this.addEdgeFromNumericUpDown.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.addEdgeFromNumericUpDown.Name = "addEdgeFromNumericUpDown";
            this.addEdgeFromNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.addEdgeFromNumericUpDown.TabIndex = 5;
            this.addEdgeFromNumericUpDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addEdgeFromNumericUpDown_KeyPress);
            // 
            // addEdgeFromLabel
            // 
            this.addEdgeFromLabel.AutoSize = true;
            this.addEdgeFromLabel.Location = new System.Drawing.Point(755, 101);
            this.addEdgeFromLabel.Name = "addEdgeFromLabel";
            this.addEdgeFromLabel.Size = new System.Drawing.Size(90, 15);
            this.addEdgeFromLabel.TabIndex = 6;
            this.addEdgeFromLabel.Text = "Add edge from:";
            // 
            // addEdgeToNumericUpDown
            // 
            this.addEdgeToNumericUpDown.Location = new System.Drawing.Point(755, 163);
            this.addEdgeToNumericUpDown.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.addEdgeToNumericUpDown.Name = "addEdgeToNumericUpDown";
            this.addEdgeToNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.addEdgeToNumericUpDown.TabIndex = 7;
            this.addEdgeToNumericUpDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addEdgeToNumericUpDown_KeyPress);
            // 
            // addEdgeToLabel
            // 
            this.addEdgeToLabel.AutoSize = true;
            this.addEdgeToLabel.Location = new System.Drawing.Point(755, 145);
            this.addEdgeToLabel.Name = "addEdgeToLabel";
            this.addEdgeToLabel.Size = new System.Drawing.Size(22, 15);
            this.addEdgeToLabel.TabIndex = 8;
            this.addEdgeToLabel.Text = "To:";
            // 
            // addEdgeButton
            // 
            this.addEdgeButton.Location = new System.Drawing.Point(881, 163);
            this.addEdgeButton.Name = "addEdgeButton";
            this.addEdgeButton.Size = new System.Drawing.Size(75, 23);
            this.addEdgeButton.TabIndex = 9;
            this.addEdgeButton.Text = "Add edge";
            this.addEdgeButton.UseVisualStyleBackColor = true;
            this.addEdgeButton.Click += new System.EventHandler(this.addEdgeButton_Click);
            // 
            // findHamiltonianPathButton
            // 
            this.findHamiltonianPathButton.Location = new System.Drawing.Point(755, 246);
            this.findHamiltonianPathButton.Name = "findHamiltonianPathButton";
            this.findHamiltonianPathButton.Size = new System.Drawing.Size(201, 41);
            this.findHamiltonianPathButton.TabIndex = 10;
            this.findHamiltonianPathButton.Text = "Find a hamiltionian path";
            this.findHamiltonianPathButton.UseVisualStyleBackColor = true;
            // 
            // hamiltonianPathLabel
            // 
            this.hamiltonianPathLabel.AutoSize = true;
            this.hamiltonianPathLabel.Location = new System.Drawing.Point(755, 290);
            this.hamiltonianPathLabel.Name = "hamiltonianPathLabel";
            this.hamiltonianPathLabel.Size = new System.Drawing.Size(228, 15);
            this.hamiltonianPathLabel.TabIndex = 11;
            this.hamiltonianPathLabel.Text = "Info about a hamiltonian path will be here";
            this.hamiltonianPathLabel.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.hamiltonianPathLabel);
            this.Controls.Add(this.findHamiltonianPathButton);
            this.Controls.Add(this.addEdgeButton);
            this.Controls.Add(this.addEdgeToLabel);
            this.Controls.Add(this.addEdgeToNumericUpDown);
            this.Controls.Add(this.addEdgeFromLabel);
            this.Controls.Add(this.addEdgeFromNumericUpDown);
            this.Controls.Add(this.addNodeButton);
            this.Controls.Add(this.addNodeNumericUpDown);
            this.Controls.Add(this.addNodeLabel);
            this.Controls.Add(this.gViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Hamiltonian path";
            ((System.ComponentModel.ISupportInitialize)(this.addNodeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addEdgeFromNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addEdgeToNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Msagl.GraphViewerGdi.GViewer gViewer;
        private Label addNodeLabel;
        private NumericUpDown addNodeNumericUpDown;
        private Button addNodeButton;
        private NumericUpDown addEdgeFromNumericUpDown;
        private Label addEdgeFromLabel;
        private NumericUpDown addEdgeToNumericUpDown;
        private Label addEdgeToLabel;
        private Button addEdgeButton;
        private Button findHamiltonianPathButton;
        private Label hamiltonianPathLabel;
    }
}