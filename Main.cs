﻿using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Collections.Generic;

namespace JungleDiamond
{

    struct ViosoFolders
    {
        public const String Root = "C:\\Users\\Public\\Documents\\VIOSO\\Anyblend";

        public const String Scripting = "\\Scripting";
        public const String Calibration = "\\Calibration";
        public const String Export = "\\Export";
    }

    struct ViosoFilters
    {
        public const String AllFiles = "All Files (*.*)|*.*";
        public const String Calibration = "Calibration (*.sps)|*.sps";
        public const String Script = "VIOSO Script (*.ini)|*.ini";
    }

    public partial class Main : Form
    {
        // Declaring global variables
        public XDocument xdoc = new XDocument(new XDeclaration("1.0", "utf-8",null ),new XElement("VIOSO"));

        public Main()
        {
            InitializeComponent();

        }
/// <summary>
/// Initializing the application
/// </summary>
        public void Main_Load(object sender, EventArgs e)
        {
            //Init of title text
            titleLabel.Text = "Script Generator v"+Application.ProductVersion;
            // Init of XML file  
            xdoc.Root.Add(new XComment("Generated by VIOSO Script Generator, v1 © 2021"));
            xdoc.Root.Add(new XElement("File", new XAttribute("version","1.0.0"), new XAttribute("build", "1234")));
        }



/// <summary>
/// Handles the choice of the functions in the dropdown: puts the corresponding Box in the active panel and shows it.
/// </summary>
        private void functionBox_indexChanged(object sender, EventArgs e)
        {
            // check if we changed to a valid index
            if (functionBox.SelectedIndex != -1)
            {
                addButton.Enabled = true;

                //show the corresponding controls
                switch (functionBox.SelectedItem.ToString())
                {
                    case "Load":
                        activePanel.Controls.Clear();
                        activePanel.Controls.Add(LoadBox);
                        LoadBox.Visible = true;
                        LoadBox.Location = new Point(0, 0);
                        break;


                    case "Copy/transfer":
                        activePanel.Controls.Clear();
                        activePanel.Controls.Add(CopyBox);
                        CopyBox.Visible = true;
                        CopyBox.Location = new Point(0, 0);
                        break;

                    case "Wait":
                        activePanel.Controls.Clear();
                        activePanel.Controls.Add(WaitBox);
                        WaitBox.Visible = true;
                        WaitBox.Location = new Point(0, 0);
                        break;

                    case "Save":
                        activePanel.Controls.Clear();
                        activePanel.Controls.Add(saveBox);
                        saveBox.Visible = true;
                        saveBox.Location = new Point(0, 0);
                        break;
                    case "Recalibrate":
                        activePanel.Controls.Clear();
                        activePanel.Controls.Add(RecalibBox);
                        RecalibBox.Visible = true;
                        RecalibBox.Location = new Point(0, 0);
                        InteractBox.SelectedIndex = 0;
                        break;
                    case "Recalculate Blending [3D]":
                        activePanel.Controls.Clear();
                        activePanel.Controls.Add(RecalBlendBox);
                        RecalBlendBox.Visible = true;
                        RecalBlendBox.Location = new Point(0, 0);
                        break;
                    case "Add VC to display Geometry":
                        activePanel.Controls.Clear();
                        activePanel.Controls.Add(AddVcBox);
                        AddVcBox.Visible = true;
                        AddVcBox.Location = new Point(0, 0);
                        break;
                    case "Custom content space conversion":
                        activePanel.Controls.Clear();
                        activePanel.Controls.Add(CCSBox);
                        CCSBox.Visible = true;
                        CCSBox.Location = new Point(0, 0);
                        break;
                    case "Export":
                        activePanel.Controls.Clear();
                        activePanel.Controls.Add(ExportBox);
                        ExportBox.Visible = true;
                        ExportBox.Location = new Point(0, 0);
                        break;


                    default:
                        activePanel.Controls.Clear();
                        Console.WriteLine("No Valid Selection");
                        break;
                }
            }



        }
 
        
/// <summary>
/// Adds the user entries to the ScriptList
/// </summary>

        private void addButton_click(object sender, EventArgs e)
        {
            //create a list item
            ListViewItem lvi = new ListViewItem();
            //fill the item depending on the function selected
            if (functionBox.SelectedIndex != -1)
                switch (functionBox.SelectedItem.ToString())
            {
                case "Load":
                    //Nb
                    lvi.Text = scriptList.Items.Count.ToString();
                    //Name
                    lvi.SubItems.Add(functionBox.SelectedItem.ToString());
                    //argument
                    lvi.SubItems.Add(loadText.Text);
                    //--> add the ScriptList
                    scriptList.Items.Add(lvi);
                    //XML elements
                    xdoc.Root.Add(new XComment("Loading Block"));
                    xdoc.Root.Add(new XElement("task", new XAttribute("action", "load"), new XAttribute("name", "Calib"), new XAttribute("type", "file"), new XAttribute("subtype", "sps"), new XAttribute("use", lvi.Text + ".Load")));
                    xdoc.Root.Add(new XElement("define", new XAttribute("name", lvi.Text + ".Load"), new XAttribute("type", "common"),
                        new XElement("param", new XAttribute("file", loadText.Text))));
                    break;

                case "Copy/transfer":
                    //Nb
                    lvi.Text = scriptList.Items.Count.ToString();
                    //Name
                    lvi.SubItems.Add(functionBox.SelectedItem.ToString());
                    //argument
                    lvi.SubItems.Add(srcText.Text + ".sps --> "+ destText.Text + ".sps");
                    //--> add the ScriptList
                    scriptList.Items.Add(lvi);
                    //XML elements
                    xdoc.Root.Add(new XComment("Transfer Block"));
                    xdoc.Root.Add(new XElement("task", new XAttribute("action", "transfer"), new XAttribute("type", "file"), new XAttribute("use", lvi.Text + ".Transfer")));
                    xdoc.Root.Add(new XElement("define", new XAttribute("name", lvi.Text + ".Transfer"), new XAttribute("type", "transfer"),
                            new XElement("from", new XAttribute("file", srcText.Text)),
                            new XElement("to", new XAttribute("file", destText.Text))));
                    break;

                case "Wait":
                    //Nb
                    lvi.Text = scriptList.Items.Count.ToString();
                    //Name
                    lvi.SubItems.Add(functionBox.SelectedItem.ToString());
                    //argument
                    lvi.SubItems.Add(waitDuration.Text + " ms");
                    //--> add the ScriptList
                    scriptList.Items.Add(lvi);
                        // XML elements
                        xdoc.Root.Add(new XComment("Waiting Block"));
                        xdoc.Root.Add(new XElement("task", new XAttribute("action", "Execute"), new XAttribute("type", "Timer"), new XAttribute("subtype", "Sleep"), new XAttribute("use", lvi.Text + ".Sleep")));
                        xdoc.Root.Add(new XElement("define", new XAttribute("name", lvi.Text + ".Sleep"), new XAttribute("type", "common"),
                                new XElement("param", new XAttribute("duration", waitDuration.Text))));
                        break;

                case "Save":
                    //Nb
                    lvi.Text = scriptList.Items.Count.ToString();
                    //Name
                    lvi.SubItems.Add(functionBox.SelectedItem.ToString());
                    //argument
                    lvi.SubItems.Add(saveText.Text);
                    //--> add the ScriptList
                    scriptList.Items.Add(lvi);
                    //clear panel
                    activePanel.Controls.Clear();
                    //XML elements
                    xdoc.Root.Add(new XComment("Saving Block"));
                    xdoc.Root.Add(new XElement("task", new XAttribute("action", "save"), new XAttribute("type", "file"), new XAttribute("subtype", "sps"), new XAttribute("use", lvi.Text + ".Save")));
                    xdoc.Root.Add(new XElement("define", new XAttribute("name", lvi.Text + ".Save"), new XAttribute("type", "common"),
                        new XElement("param", new XAttribute("file", saveText.Text))));
                    break;
                case "Recalibrate":
                    //Nb
                    lvi.Text = scriptList.Items.Count.ToString();
                    //Name
                    lvi.SubItems.Add(functionBox.SelectedItem.ToString());
                    //argument
                    lvi.SubItems.Add(compoundRecalText.Text+", [Interaction: "+InteractBox.SelectedItem.ToString()+"]");
                    //--> add the ScriptList
                    scriptList.Items.Add(lvi);
                    //XML elements
                        //tasks
                    xdoc.Root.Add(new XComment("Recalibration Block"));
                    xdoc.Root.Add(new XElement("task", new XAttribute("action", "create"), new XAttribute("name", "Recalib"), new XAttribute("type", "behaviour"), new XAttribute("subtype", "SingleClientCalib"), new XAttribute("use", lvi.Text + ".Recalibration")));
                    xdoc.Root.Add(new XElement("task", new XAttribute("action", "wait"), new XAttribute("name", "Recalib"), new XAttribute("state", "finished")));
                    xdoc.Root.Add(new XElement("task", new XAttribute("action", "execute"), new XAttribute("type", "timer"), new XAttribute("subtype", "sleep"), new XAttribute("use", "stdWait")));
                        //define
                    xdoc.Root.Add(new XElement("define", new XAttribute("name", lvi.Text + ".Recalibration"), new XAttribute("type", "BehaviourCreate"),
                                new XElement("param", new XAttribute("interactLevel",InteractBox.SelectedItem.ToString())),
                                new XElement("display", new XAttribute("tDevice","dc"), new XAttribute("name", compoundRecalText.Text))));
                        break;
                case "Recalculate Blending [3D]":
                    //Nb
                    lvi.Text = scriptList.Items.Count.ToString();
                    //Name
                    lvi.SubItems.Add(functionBox.SelectedItem.ToString());
                    //argument
                    lvi.SubItems.Add(compoundBlendText.Text);
                    //--> add the ScriptList
                    scriptList.Items.Add(lvi);
                    //XML elements
                        //tasks
                    xdoc.Root.Add(new XComment("Blending Recalibration [3D] Block"));
                    xdoc.Root.Add(new XElement("task", new XAttribute("action", "create"), new XAttribute("name", "BlendCal"), new XAttribute("type", "behaviour"), new XAttribute("subtype", "SingleClientCalib"), new XAttribute("use", lvi.Text + ".BlendCalc.Start")));
                    xdoc.Root.Add(new XElement("task", new XAttribute("action", "wait"), new XAttribute("name", "BlendCal"), new XAttribute("state", "Interact.DeviceSel")));
                    xdoc.Root.Add(new XElement("task", new XAttribute("action", "configure"), new XAttribute("name", "BlendCal"), new XAttribute("state", "DeviceSel"), new XAttribute("use", lvi.Text + ".BlendCalc.Config")));
                    xdoc.Root.Add(new XElement("task", new XAttribute("action", "execute"), new XAttribute("name", "BlendCalc"), new XAttribute("type", "progress"), new XAttribute("subtype", "next")));
                    xdoc.Root.Add(new XElement("task", new XAttribute("action", "wait"), new XAttribute("name", "BlendCalc"), new XAttribute("state", "finished")));
                    xdoc.Root.Add(new XElement("task", new XAttribute("action", "execute"), new XAttribute("type", "timer"), new XAttribute("subtype", "sleep"), new XAttribute("use", "stdWait")));
                        //define
                    xdoc.Root.Add(new XElement("define", new XAttribute("name", lvi.Text + ".BlendCalc.Start"), new XAttribute("type", "BehaviourCreate"),
                                new XElement("param", new XAttribute("interactLevel", "many,noFinalResult")),
                                new XElement("display", new XAttribute("tDevice","dc"), new XAttribute("name", compoundBlendText.Text))));
                    xdoc.Root.Add(new XElement("define", new XAttribute("name", lvi.Text + ".BlendCalc.Config"), new XAttribute("type", "SC_DevSel"),
                                new XElement("param", new XAttribute("tCalib", "preceeding"), new XAttribute("tArrangement", "hstrip"), new XAttribute("calibName", compoundBlendText.Text+"_Reblended"))));
                    break;
                case "Add VC to display Geometry":
                    //Nb
                    lvi.Text = scriptList.Items.Count.ToString();
                    //Name
                    lvi.SubItems.Add(functionBox.SelectedItem.ToString());
                    //argument
                    lvi.SubItems.Add(compoundVCText.Text);
                    //--> add the ScriptList
                    scriptList.Items.Add(lvi);
                    //XML elements
                        //tasks
                    xdoc.Root.Add(new XComment("Conversion Block: Add VC to display geometry"));
                    xdoc.Root.Add(new XElement("task", new XAttribute("action", "create"), new XAttribute("name", "AddVCtoP2C"), new XAttribute("type", "behaviour"), new XAttribute("subtype", "Convert")));
                    xdoc.Root.Add(new XElement("task", new XAttribute("action", "wait"), new XAttribute("name", "AddVCtoP2C"), new XAttribute("state", "Interact.Convert")));
                    xdoc.Root.Add(new XElement("task", new XAttribute("action", "configure"), new XAttribute("name", "AddVCtoP2C"), new XAttribute("state", "ConvertConfig"), new XAttribute("use", lvi.Text + ".AddVC")));
                    xdoc.Root.Add(new XElement("task", new XAttribute("action", "start"), new XAttribute("name", "AddVCtoP2C")));
                    xdoc.Root.Add(new XElement("task", new XAttribute("action", "wait"), new XAttribute("name", "AddVCtoP2C"), new XAttribute("state", "finished")));
                    xdoc.Root.Add(new XElement("task", new XAttribute("action", "execute"), new XAttribute("type", "timer"), new XAttribute("subtype", "sleep"), new XAttribute("use", "stdWait")));

                        //define
                    xdoc.Root.Add(new XElement("define", new XAttribute("name", lvi.Text + ".AddVC"), new XAttribute("type", "CalibCommerce"),
                                     new XElement("display", new XAttribute("tDevice", "dc"), new XAttribute("name", compoundVCText.Text)),
                                     new XElement("param", new XAttribute("tConvert", "add vc to P2C"))));
                    break;
                case "Custom content space conversion":
                    //Nb
                    lvi.Text = scriptList.Items.Count.ToString();
                    //Name
                    lvi.SubItems.Add(functionBox.SelectedItem.ToString());
                    //argument
                    lvi.SubItems.Add(compoundCCSText.Text+", Space: "+ccsText.Text);
                    //--> add the ScriptList
                    scriptList.Items.Add(lvi);

                    //XML Elements
                    //Tasks
                    xdoc.Root.Add(new XComment("Conversion Block: Custom content space conversion"));
                    xdoc.Root.Add(new XElement("task", new XAttribute("action", "create"), new XAttribute("name", "ContentSpace"), new XAttribute("type", "behaviour"), new XAttribute("subtype", "Convert")));
                    xdoc.Root.Add(new XElement("task", new XAttribute("action", "wait"), new XAttribute("name", "ContentSpace"), new XAttribute("state", "Interact.Convert")));
                    xdoc.Root.Add(new XElement("task", new XAttribute("action", "configure"), new XAttribute("name", "ContentSpace"), new XAttribute("state", "ConvertConfig"), new XAttribute("use", lvi.Text + ".CCS_BLOCK")));
                    xdoc.Root.Add(new XElement("task", new XAttribute("action", "start"), new XAttribute("name", "ContentSpace")));
                    xdoc.Root.Add(new XElement("task", new XAttribute("action", "wait"), new XAttribute("name", "ContentSpace"), new XAttribute("state", "finished")));
                    xdoc.Root.Add(new XElement("task", new XAttribute("action", "execute"), new XAttribute("type", "timer"), new XAttribute("subtype", "sleep"), new XAttribute("use", "stdWait")));

                    //define
                    xdoc.Root.Add(new XElement("define", new XAttribute("name", lvi.Text + ".CCS_BLOCK"), new XAttribute("type", "CalibCommerce"),
                                    new XElement("display", new XAttribute("tDevice", "dc"), new XAttribute("name", compoundCCSText.Text)),
                                    new XElement("param", new XAttribute("tConvert", "custom content space conversion"), new XAttribute("customContentSpace", ccsText.Text))
                                  ));

                    break;
                case "Export":

                    String fullPath = expPath.Text + @"\" + expName.Text + "." + expFormat.Text;

                    //Nb
                    lvi.Text = scriptList.Items.Count.ToString();
                    //Name
                    lvi.SubItems.Add(functionBox.SelectedItem.ToString());
                    //argument
                    lvi.SubItems.Add(compoundExpText.Text + ", " + fullPath);
                    //--> add the ScriptList
                    scriptList.Items.Add(lvi);
  
                    //XML Elements
                    //Task
                    xdoc.Root.Add(new XComment("Export Block"));
                    xdoc.Root.Add(new XElement("task", new XAttribute("action", "create"), new XAttribute("name", "Export1"), new XAttribute("type", "behaviour"), new XAttribute("subtype", "export")));
                    xdoc.Root.Add(new XElement("task", new XAttribute("action", "wait"), new XAttribute("name", "Export1"), new XAttribute("state", "Interact.Export")));
                    xdoc.Root.Add(new XElement("taks", new XAttribute("action", "configure"), new XAttribute("name", "Export1"), new XAttribute("state", "ExportConfig"),
                                    new XElement("display", new XAttribute("tDevice", "dc"), new XAttribute("name", compoundExpText.Text)),
                                    new XElement("param", new XAttribute("tConvert", expFormat.Text), new XAttribute("path", fullPath), new XAttribute("name", expName.Text), new XAttribute("bSplitDisplays", "1"), new XAttribute("bExactFileName", "1"))
                                  ));
                    xdoc.Root.Add(new XElement("task", new XAttribute("action", "start"), new XAttribute("name", "Export1")));
                    xdoc.Root.Add(new XElement("task", new XAttribute("action", "wait"), new XAttribute("name", "Export1"), new XAttribute("state", "finished")));
                        
                    break;

                default:
                    Console.WriteLine("No Valid Selection");
                    break;
            }
            //Butto & UI reset
            addButton.Enabled = false;
            activePanel.Controls.Clear();
            functionBox.SelectedIndex = -1;
 
        }


        /// <summary>
        /// Generates and saves the XML document
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void generateScript_Click(object sender, EventArgs e)
        {
            //generate common XML elements
            xdoc.Root.Add(new XElement("define", new XAttribute("name", "stdWait"), new XAttribute("type", "common"),
            new XElement("param", new XAttribute("duration", "3000"))));
            //SAVE dialog
            String saveFileName = String.Empty;
            if (showSaveFileDialog(ref saveFileName, ViosoFolders.Scripting, ViosoFilters.Script)) 
            {
                //Write XML file with UTF8 and no BOM
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Encoding = new UTF8Encoding(false); // do not emit the BOM.
                settings.Indent = true; 
                using (XmlWriter w = XmlWriter.Create(saveFileName, settings))
                {
                    xdoc.Save(w);
                }
            }

        }

       /// <summary>
       /// Shows a SaveFileDialog and writes the selected Filename in 'saveFile'.
       /// Returns true, if a file name is selected.
       /// </summary>
       /// <param name="saveFile">File name</param>
       /// <returns>true, if a file name is selected</returns>
        private bool showSaveFileDialog(ref String saveFile, String viosoFolder, String viosoFilter)
        {
            saveFileDialog1.FileName = String.Empty;
            saveFileDialog1.Filter = viosoFilter;
            saveFileDialog1.InitialDirectory = ViosoFolders.Root + viosoFolder;
            DialogResult dialogResult = saveFileDialog1.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                saveFile = saveFileDialog1.FileName;
            }

            return saveFile.Length > 0;
        }

        /// <summary>
        /// Shows a FolderBrowseDialog and writes the selected Folder path in 'selectedPath'.
        /// Returns true, if a folder name is selected.
        /// </summary>
        /// <param name="selectedPath">Folder name</param>
        /// <returns>true, if a folder is selected</returns>
        private bool showSelectFolderDialog(ref String selectedPath) 
        {
            DialogResult dialogResult = folderBrowserDialog1.ShowDialog();
            
            if (dialogResult == DialogResult.OK) 
            {
                selectedPath = folderBrowserDialog1.SelectedPath;
            }

            return selectedPath.Length > 0;
        }

        /// <summary>
        /// Shows a OpenFileDialog and writes the selected Filename in 'selectedFile'.
        /// Returns true, if a file is selected.
        /// </summary>
        /// <param name="selectedFile">File name</param>
        /// <returns>true, if a file is selected</returns>
        private bool showSelectFileDialog(ref String selectedFile, String viosoFolder)
        {
            openFileDialog1.Filter = ViosoFilters.Calibration + "|" + ViosoFilters.AllFiles;
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = ViosoFolders.Root + viosoFolder;
            DialogResult dialogResult = openFileDialog1.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                String fileName = openFileDialog1.FileName;
                int index = fileName.LastIndexOf("\\") + 1;
                selectedFile = fileName.Substring(index);
            }

            return selectedFile.Length > 0;
        }

        /// <summary>
        /// Reset the GUI and XML
        /// </summary>
        private void resetButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Reset");
            xdoc.Root.RemoveAll();
            scriptList.Items.Clear();
            addButton.Enabled = false;
            activePanel.Controls.Clear();
            functionBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Handle the click event for the SelectExportDestination Button.
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void btnSelectExportDestination_Click(object sender, EventArgs e)
        {
            String selectedPath = String.Empty;
            if (showSelectFolderDialog(ref selectedPath))
            {
                expPath.Text = selectedPath;
            }
        }

        /// <summary>
        /// Handle the click event for the Load Button.
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void btnLoad_Click(object sender, EventArgs e)
        {
            String selectedFile = String.Empty;
            if (showSelectFileDialog(ref selectedFile, ViosoFolders.Calibration))
            {
                loadText.Text = selectedFile;
            }
        }

        /// <summary>
        /// Handle the click event for the BrowseSourceTransfer Button.
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void btnBrowseSourceTransfer_Click(object sender, EventArgs e)
        {
            String selectedFile = String.Empty;
            if (showSelectFileDialog(ref selectedFile, ViosoFolders.Calibration))
            {
                srcText.Text = selectedFile;
            }
        }

        /// <summary>
        /// Handle the click event for the BrowseDestinationTransfer Button.
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void btnBrowseDestinationTransfer_Click(object sender, EventArgs e)
        {
            String destinationFile = String.Empty;
            if (showSaveFileDialog(ref destinationFile, ViosoFolders.Calibration, ViosoFilters.Calibration))
            {
                destText.Text = destinationFile;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String saveFile = String.Empty;
            if (showSaveFileDialog(ref saveFile, ViosoFolders.Calibration, ViosoFilters.Calibration))
            {
                int index = saveFile.LastIndexOf("\\") + 1;
                saveText.Text = saveFile.Substring(index);
            }
        }
    }
}
