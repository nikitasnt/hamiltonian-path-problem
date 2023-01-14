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
            this.nodeLabel = new System.Windows.Forms.Label();
            this.nodeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.addNodeButton = new System.Windows.Forms.Button();
            this.edgeFromNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.edgeFromLabel = new System.Windows.Forms.Label();
            this.edgeToNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.edgeToLabel = new System.Windows.Forms.Label();
            this.addEdgeButton = new System.Windows.Forms.Button();
            this.findHamiltonianPathButton = new System.Windows.Forms.Button();
            this.hamiltonianPathLabel = new System.Windows.Forms.Label();
            this.removeNodeButton = new System.Windows.Forms.Button();
            this.removeEdgeButton = new System.Windows.Forms.Button();
            this.clearGraphButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nodeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edgeFromNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edgeToNumericUpDown)).BeginInit();
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
            this.gViewer.EdgeInsertButtonVisible = false;
            this.gViewer.FileName = "";
            this.gViewer.ForwardEnabled = false;
            this.gViewer.Graph = null;
            this.gViewer.InsertingEdge = false;
            this.gViewer.LayoutAlgorithmSettingsButtonVisible = true;
            this.gViewer.LayoutEditingEnabled = false;
            this.gViewer.Location = new System.Drawing.Point(12, 12);
            this.gViewer.LooseOffsetForRouting = 0.25D;
            this.gViewer.MouseHitDistance = 0.05D;
            this.gViewer.Name = "gViewer";
            this.gViewer.NavigationVisible = false;
            this.gViewer.NeedToCalculateLayout = true;
            this.gViewer.OffsetForRelaxingInRouting = 0.6D;
            this.gViewer.PaddingForEdgeRouting = 8D;
            this.gViewer.PanButtonPressed = false;
            this.gViewer.SaveAsImageEnabled = false;
            this.gViewer.SaveAsMsaglEnabled = false;
            this.gViewer.SaveButtonVisible = false;
            this.gViewer.SaveGraphButtonVisible = false;
            this.gViewer.SaveInVectorFormatEnabled = false;
            this.gViewer.Size = new System.Drawing.Size(752, 637);
            this.gViewer.TabIndex = 0;
            this.gViewer.TightOffsetForRouting = 0.125D;
            this.gViewer.ToolBarIsVisible = false;
            this.gViewer.Transform = ((Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation)(resources.GetObject("gViewer.Transform")));
            this.gViewer.UndoRedoButtonsVisible = false;
            this.gViewer.WindowZoomButtonPressed = false;
            this.gViewer.ZoomF = 1D;
            this.gViewer.ZoomWindowThreshold = 0.05D;
            // 
            // nodeLabel
            // 
            this.nodeLabel.AutoSize = true;
            this.nodeLabel.Location = new System.Drawing.Point(770, 12);
            this.nodeLabel.Name = "nodeLabel";
            this.nodeLabel.Size = new System.Drawing.Size(84, 15);
            this.nodeLabel.TabIndex = 1;
            this.nodeLabel.Text = "Node number:";
            // 
            // nodeNumericUpDown
            // 
            this.nodeNumericUpDown.Location = new System.Drawing.Point(770, 30);
            this.nodeNumericUpDown.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nodeNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nodeNumericUpDown.Name = "nodeNumericUpDown";
            this.nodeNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.nodeNumericUpDown.TabIndex = 2;
            this.nodeNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nodeNumericUpDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addNodeNumericUpDown_KeyPress);
            // 
            // addNodeButton
            // 
            this.addNodeButton.Location = new System.Drawing.Point(896, 12);
            this.addNodeButton.Name = "addNodeButton";
            this.addNodeButton.Size = new System.Drawing.Size(120, 41);
            this.addNodeButton.TabIndex = 3;
            this.addNodeButton.Text = "Add node";
            this.addNodeButton.UseVisualStyleBackColor = true;
            this.addNodeButton.Click += new System.EventHandler(this.addNodeButton_Click);
            // 
            // edgeFromNumericUpDown
            // 
            this.edgeFromNumericUpDown.Location = new System.Drawing.Point(770, 119);
            this.edgeFromNumericUpDown.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.edgeFromNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edgeFromNumericUpDown.Name = "edgeFromNumericUpDown";
            this.edgeFromNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.edgeFromNumericUpDown.TabIndex = 5;
            this.edgeFromNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edgeFromNumericUpDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addEdgeFromNumericUpDown_KeyPress);
            // 
            // edgeFromLabel
            // 
            this.edgeFromLabel.AutoSize = true;
            this.edgeFromLabel.Location = new System.Drawing.Point(770, 101);
            this.edgeFromLabel.Name = "edgeFromLabel";
            this.edgeFromLabel.Size = new System.Drawing.Size(95, 15);
            this.edgeFromLabel.TabIndex = 6;
            this.edgeFromLabel.Text = "Edge from node:";
            // 
            // edgeToNumericUpDown
            // 
            this.edgeToNumericUpDown.Location = new System.Drawing.Point(770, 163);
            this.edgeToNumericUpDown.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.edgeToNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edgeToNumericUpDown.Name = "edgeToNumericUpDown";
            this.edgeToNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.edgeToNumericUpDown.TabIndex = 7;
            this.edgeToNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edgeToNumericUpDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addEdgeToNumericUpDown_KeyPress);
            // 
            // edgeToLabel
            // 
            this.edgeToLabel.AutoSize = true;
            this.edgeToLabel.Location = new System.Drawing.Point(770, 145);
            this.edgeToLabel.Name = "edgeToLabel";
            this.edgeToLabel.Size = new System.Drawing.Size(22, 15);
            this.edgeToLabel.TabIndex = 8;
            this.edgeToLabel.Text = "To:";
            // 
            // addEdgeButton
            // 
            this.addEdgeButton.Location = new System.Drawing.Point(896, 145);
            this.addEdgeButton.Name = "addEdgeButton";
            this.addEdgeButton.Size = new System.Drawing.Size(120, 41);
            this.addEdgeButton.TabIndex = 9;
            this.addEdgeButton.Text = "Add edge";
            this.addEdgeButton.UseVisualStyleBackColor = true;
            this.addEdgeButton.Click += new System.EventHandler(this.addEdgeButton_Click);
            // 
            // findHamiltonianPathButton
            // 
            this.findHamiltonianPathButton.Location = new System.Drawing.Point(770, 349);
            this.findHamiltonianPathButton.Name = "findHamiltonianPathButton";
            this.findHamiltonianPathButton.Size = new System.Drawing.Size(246, 41);
            this.findHamiltonianPathButton.TabIndex = 10;
            this.findHamiltonianPathButton.Text = "Find a hamiltionian path";
            this.findHamiltonianPathButton.UseVisualStyleBackColor = true;
            this.findHamiltonianPathButton.Click += new System.EventHandler(this.findHamiltonianPathButton_Click);
            // 
            // hamiltonianPathLabel
            // 
            this.hamiltonianPathLabel.AutoSize = true;
            this.hamiltonianPathLabel.Location = new System.Drawing.Point(770, 393);
            this.hamiltonianPathLabel.MaximumSize = new System.Drawing.Size(246, 0);
            this.hamiltonianPathLabel.Name = "hamiltonianPathLabel";
            this.hamiltonianPathLabel.Size = new System.Drawing.Size(228, 15);
            this.hamiltonianPathLabel.TabIndex = 11;
            this.hamiltonianPathLabel.Text = "Info about a hamiltonian path will be here";
            this.hamiltonianPathLabel.Visible = false;
            // 
            // removeNodeButton
            // 
            this.removeNodeButton.Location = new System.Drawing.Point(927, 59);
            this.removeNodeButton.Name = "removeNodeButton";
            this.removeNodeButton.Size = new System.Drawing.Size(89, 23);
            this.removeNodeButton.TabIndex = 12;
            this.removeNodeButton.Text = "Remove node";
            this.removeNodeButton.UseVisualStyleBackColor = true;
            this.removeNodeButton.Click += new System.EventHandler(this.removeNodeButton_Click);
            // 
            // removeEdgeButton
            // 
            this.removeEdgeButton.Location = new System.Drawing.Point(927, 192);
            this.removeEdgeButton.Name = "removeEdgeButton";
            this.removeEdgeButton.Size = new System.Drawing.Size(89, 23);
            this.removeEdgeButton.TabIndex = 13;
            this.removeEdgeButton.Text = "Remove edge";
            this.removeEdgeButton.UseVisualStyleBackColor = true;
            this.removeEdgeButton.Click += new System.EventHandler(this.removeEdgeButton_Click);
            // 
            // clearGraphButton
            // 
            this.clearGraphButton.Location = new System.Drawing.Point(927, 258);
            this.clearGraphButton.Name = "clearGraphButton";
            this.clearGraphButton.Size = new System.Drawing.Size(89, 41);
            this.clearGraphButton.TabIndex = 14;
            this.clearGraphButton.Text = "Clear graph";
            this.clearGraphButton.UseVisualStyleBackColor = true;
            this.clearGraphButton.Click += new System.EventHandler(this.clearGraphButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 661);
            this.Controls.Add(this.clearGraphButton);
            this.Controls.Add(this.removeEdgeButton);
            this.Controls.Add(this.removeNodeButton);
            this.Controls.Add(this.hamiltonianPathLabel);
            this.Controls.Add(this.findHamiltonianPathButton);
            this.Controls.Add(this.addEdgeButton);
            this.Controls.Add(this.edgeToLabel);
            this.Controls.Add(this.edgeToNumericUpDown);
            this.Controls.Add(this.edgeFromLabel);
            this.Controls.Add(this.edgeFromNumericUpDown);
            this.Controls.Add(this.addNodeButton);
            this.Controls.Add(this.nodeNumericUpDown);
            this.Controls.Add(this.nodeLabel);
            this.Controls.Add(this.gViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Hamiltonian path";
            ((System.ComponentModel.ISupportInitialize)(this.nodeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edgeFromNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edgeToNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Msagl.GraphViewerGdi.GViewer gViewer;
        private Label nodeLabel;
        private NumericUpDown nodeNumericUpDown;
        private Button addNodeButton;
        private NumericUpDown edgeFromNumericUpDown;
        private Label edgeFromLabel;
        private NumericUpDown edgeToNumericUpDown;
        private Label edgeToLabel;
        private Button addEdgeButton;
        private Button findHamiltonianPathButton;
        private Label hamiltonianPathLabel;
        private Button removeNodeButton;
        private Button removeEdgeButton;
        private Button clearGraphButton;
    }
}