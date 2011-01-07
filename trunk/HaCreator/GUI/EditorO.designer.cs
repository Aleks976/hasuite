﻿/*  HaCreator - MapleStory Map Editor
 * Copyright (C) 2009, 2010  haha01haha01
   
 * This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

 * This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

 * You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.*/

namespace HaCreator.GUI
{
    partial class Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.ribbonControl = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel2 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.itemContainer8 = new DevComponents.DotNetBar.ItemContainer();
            this.layersComboBox = new DevComponents.DotNetBar.ComboBoxItem();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.comboItem5 = new DevComponents.Editors.ComboItem();
            this.comboItem6 = new DevComponents.Editors.ComboItem();
            this.comboItem7 = new DevComponents.Editors.ComboItem();
            this.comboItem8 = new DevComponents.Editors.ComboItem();
            this.allLayersBox = new DevComponents.DotNetBar.CheckBoxItem();
            this.viewOtherBar = new DevComponents.DotNetBar.RibbonBar();
            this.viewMapObjsBar = new DevComponents.DotNetBar.RibbonBar();
            this.itemContainer7 = new DevComponents.DotNetBar.ItemContainer();
            this.viewTiles = new DevComponents.DotNetBar.CheckBoxItem();
            this.checkBoxItem1 = new DevComponents.DotNetBar.CheckBoxItem();
            this.viewObjs = new DevComponents.DotNetBar.CheckBoxItem();
            this.viewNpcs = new DevComponents.DotNetBar.CheckBoxItem();
            this.viewMobs = new DevComponents.DotNetBar.CheckBoxItem();
            this.viewReactors = new DevComponents.DotNetBar.CheckBoxItem();
            this.viewPortals = new DevComponents.DotNetBar.CheckBoxItem();
            this.viewFhs = new DevComponents.DotNetBar.CheckBoxItem();
            this.viewRopes = new DevComponents.DotNetBar.CheckBoxItem();
            this.viewSeats = new DevComponents.DotNetBar.CheckBoxItem();
            this.viewTooltips = new DevComponents.DotNetBar.CheckBoxItem();
            this.viewBackgrounds = new DevComponents.DotNetBar.CheckBoxItem();
            this.ribbonPanel3 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar5 = new DevComponents.DotNetBar.RibbonBar();
            this.itemContainer10 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.viewTab = new DevComponents.DotNetBar.RibbonTabItem();
            this.Tools = new DevComponents.DotNetBar.RibbonTabItem();
            this.itemContainer9 = new DevComponents.DotNetBar.ItemContainer();
            this.fhsEditMode = new DevComponents.DotNetBar.ButtonItem();
            this.ropeEditMode = new DevComponents.DotNetBar.ButtonItem();
            this.chairsEditMode = new DevComponents.DotNetBar.ButtonItem();
            this.tooltipsEditMode = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainer6 = new DevComponents.DotNetBar.ItemContainer();
            this.tilesEditMode = new DevComponents.DotNetBar.ButtonItem();
            this.objsEditMode = new DevComponents.DotNetBar.ButtonItem();
            this.npcsEditMode = new DevComponents.DotNetBar.ButtonItem();
            this.mobEditMode = new DevComponents.DotNetBar.ButtonItem();
            this.reactEditMode = new DevComponents.DotNetBar.ButtonItem();
            this.portalEditMode = new DevComponents.DotNetBar.ButtonItem();
            this.qatCustomizeItem1 = new DevComponents.DotNetBar.QatCustomizeItem();
            this.cordsLabel = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip = new System.Windows.Forms.ToolStrip();
            this.itemDescLabel = new System.Windows.Forms.ToolStripLabel();
            this.styleManager = new DevComponents.DotNetBar.StyleManager(this.components);
            this.dotNetBarManager = new DevComponents.DotNetBar.DotNetBarManager(this.components);
            this.dockSite4 = new DevComponents.DotNetBar.DockSite();
            this.dockSite1 = new DevComponents.DotNetBar.DockSite();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.panelDockContainer7 = new DevComponents.DotNetBar.PanelDockContainer();
            this.dockContainerItem3 = new DevComponents.DotNetBar.DockContainerItem();
            this.dockSite2 = new DevComponents.DotNetBar.DockSite();
            this.dockBar = new DevComponents.DotNetBar.Bar();
            this.panelDockContainer1 = new DevComponents.DotNetBar.PanelDockContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tileBrowse = new System.Windows.Forms.Button();
            this.tileSetList = new System.Windows.Forms.ListBox();
            this.tileImagesContainer = new HaCreator.KoolkLVContainer();
            this.panelDockContainer4 = new DevComponents.DotNetBar.PanelDockContainer();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.bgSetListBox = new System.Windows.Forms.ListBox();
            this.bgBack = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.aniBg = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.bgImageContainer = new HaCreator.KoolkLVContainer();
            this.panelDockContainer3 = new DevComponents.DotNetBar.PanelDockContainer();
            this.splitContainer8 = new System.Windows.Forms.SplitContainer();
            this.splitContainer9 = new System.Windows.Forms.SplitContainer();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.lifeSearchBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.mobRButton = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.npcRButton = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.reactorRButton = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.lifeListBox = new System.Windows.Forms.ListBox();
            this.panelDockContainer5 = new DevComponents.DotNetBar.PanelDockContainer();
            this.portalImageContainer = new HaCreator.KoolkLVContainer();
            this.panelDockContainer6 = new DevComponents.DotNetBar.PanelDockContainer();
            this.miscItemsContainer = new HaCreator.KoolkLVContainer();
            this.panelDockContainer2 = new DevComponents.DotNetBar.PanelDockContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.objSetListBox = new System.Windows.Forms.ListBox();
            this.objL0ListBox = new System.Windows.Forms.ListBox();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.objL1ListBox = new System.Windows.Forms.ListBox();
            this.objImagesContainer = new HaCreator.KoolkLVContainer();
            this.objsDockBox = new DevComponents.DotNetBar.DockContainerItem();
            this.bgDockBox = new DevComponents.DotNetBar.DockContainerItem();
            this.lifeDockBox = new DevComponents.DotNetBar.DockContainerItem();
            this.portalDockBox = new DevComponents.DotNetBar.DockContainerItem();
            this.objDockBox = new DevComponents.DotNetBar.DockContainerItem();
            this.bar2 = new DevComponents.DotNetBar.Bar();
            this.panelDockContainer8 = new DevComponents.DotNetBar.PanelDockContainer();
            this.dockContainerItem4 = new DevComponents.DotNetBar.DockContainerItem();
            this.dockSite8 = new DevComponents.DotNetBar.DockSite();
            this.dockSite5 = new DevComponents.DotNetBar.DockSite();
            this.dockSite6 = new DevComponents.DotNetBar.DockSite();
            this.dockSite7 = new DevComponents.DotNetBar.DockSite();
            this.dockSite3 = new DevComponents.DotNetBar.DockSite();
            this.tileDockBox = new DevComponents.DotNetBar.DockContainerItem();
            this.Tabs = new TabPages.PageCollection();
            this.multiBoard = new HaCreator.MapEditor.MultiBoard();
            this.showVR = new DevComponents.DotNetBar.ButtonItem();
            this.showMinimap = new DevComponents.DotNetBar.ButtonItem();
            this.emulateParallax = new DevComponents.DotNetBar.ButtonItem();
            this.settingsButton = new DevComponents.DotNetBar.ButtonItem();
            this.mapSimulatorButton = new DevComponents.DotNetBar.ButtonItem();
            this.btnHaRepacker = new DevComponents.DotNetBar.ButtonItem();
            this.regenMinimap = new DevComponents.DotNetBar.ButtonItem();
            this.snapButton = new DevComponents.DotNetBar.ButtonItem();
            this.randomTiles = new DevComponents.DotNetBar.ButtonItem();
            this.StartButton = new DevComponents.DotNetBar.Office2007StartButton();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer2 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer3 = new DevComponents.DotNetBar.ItemContainer();
            this.openButton = new DevComponents.DotNetBar.ButtonItem();
            this.saveButton = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.infoButton = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainer4 = new DevComponents.DotNetBar.ItemContainer();
            this.labelItem8 = new DevComponents.DotNetBar.LabelItem();
            this.buttonItem8 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem9 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem10 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem11 = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainer5 = new DevComponents.DotNetBar.ItemContainer();
            this.settingsMenuButton = new DevComponents.DotNetBar.ButtonItem();
            this.exitButton = new DevComponents.DotNetBar.ButtonItem();
            this.undoButton = new DevComponents.DotNetBar.ButtonItem();
            this.redoButton = new DevComponents.DotNetBar.ButtonItem();
            this.lifePictureBox = new System.Windows.Forms.PictureBox();
            this.ribbonControl.SuspendLayout();
            this.ribbonPanel2.SuspendLayout();
            this.ribbonPanel3.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.dockSite1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.bar1.SuspendLayout();
            this.dockSite2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dockBar)).BeginInit();
            this.dockBar.SuspendLayout();
            this.panelDockContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panelDockContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            this.panelDockContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).BeginInit();
            this.splitContainer8.Panel1.SuspendLayout();
            this.splitContainer8.Panel2.SuspendLayout();
            this.splitContainer8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer9)).BeginInit();
            this.splitContainer9.Panel1.SuspendLayout();
            this.splitContainer9.Panel2.SuspendLayout();
            this.splitContainer9.SuspendLayout();
            this.panelDockContainer5.SuspendLayout();
            this.panelDockContainer6.SuspendLayout();
            this.panelDockContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar2)).BeginInit();
            this.bar2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lifePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            // 
            // 
            // 
            this.ribbonControl.BackgroundStyle.Class = "";
            this.ribbonControl.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonControl.CaptionVisible = true;
            this.ribbonControl.Controls.Add(this.ribbonPanel2);
            this.ribbonControl.Controls.Add(this.ribbonPanel3);
            this.ribbonControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.viewTab,
            this.Tools});
            this.ribbonControl.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl.Location = new System.Drawing.Point(85, 1);
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ribbonControl.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.StartButton,
            this.undoButton,
            this.redoButton});
            this.ribbonControl.Size = new System.Drawing.Size(778, 152);
            this.ribbonControl.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonControl.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.ribbonControl.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.ribbonControl.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.ribbonControl.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.ribbonControl.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.ribbonControl.SystemText.QatDialogAddButton = "&Add >>";
            this.ribbonControl.SystemText.QatDialogCancelButton = "Cancel";
            this.ribbonControl.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.ribbonControl.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.ribbonControl.SystemText.QatDialogOkButton = "OK";
            this.ribbonControl.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl.SystemText.QatDialogRemoveButton = "&Remove";
            this.ribbonControl.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.ribbonControl.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.ribbonControl.TabGroupHeight = 14;
            this.ribbonControl.TabIndex = 4;
            this.ribbonControl.Text = "Map Objects";
            this.ribbonControl.LocationChanged += new System.EventHandler(this.ribbonControlChanged);
            this.ribbonControl.SizeChanged += new System.EventHandler(this.ribbonControlChanged);
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel2.Controls.Add(this.ribbonBar1);
            this.ribbonPanel2.Controls.Add(this.viewOtherBar);
            this.ribbonPanel2.Controls.Add(this.viewMapObjsBar);
            this.ribbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel2.Location = new System.Drawing.Point(0, 56);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel2.Size = new System.Drawing.Size(778, 94);
            // 
            // 
            // 
            this.ribbonPanel2.Style.Class = "";
            this.ribbonPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseDown.Class = "";
            this.ribbonPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseOver.Class = "";
            this.ribbonPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel2.TabIndex = 2;
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundMouseOverStyle.Class = "";
            this.ribbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundStyle.Class = "";
            this.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer8});
            this.ribbonBar1.Location = new System.Drawing.Point(607, 0);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(249, 91);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar1.TabIndex = 2;
            this.ribbonBar1.Text = "Layer";
            // 
            // 
            // 
            this.ribbonBar1.TitleStyle.Class = "";
            this.ribbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyleMouseOver.Class = "";
            this.ribbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // itemContainer8
            // 
            // 
            // 
            // 
            this.itemContainer8.BackgroundStyle.Class = "";
            this.itemContainer8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer8.Name = "itemContainer8";
            this.itemContainer8.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.layersComboBox,
            this.allLayersBox});
            this.itemContainer8.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // layersComboBox
            // 
            this.layersComboBox.ComboWidth = 130;
            this.layersComboBox.DropDownHeight = 106;
            this.layersComboBox.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2,
            this.comboItem3,
            this.comboItem4,
            this.comboItem5,
            this.comboItem6,
            this.comboItem7,
            this.comboItem8});
            this.layersComboBox.Name = "layersComboBox";
            this.layersComboBox.SelectedIndexChanged += new System.EventHandler(this.layersComboBox_SelectedIndexChanged);
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "0";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "1";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "2";
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "3";
            // 
            // comboItem5
            // 
            this.comboItem5.Text = "4";
            // 
            // comboItem6
            // 
            this.comboItem6.Text = "5";
            // 
            // comboItem7
            // 
            this.comboItem7.Text = "6";
            // 
            // comboItem8
            // 
            this.comboItem8.Text = "7";
            // 
            // allLayersBox
            // 
            this.allLayersBox.Name = "allLayersBox";
            this.allLayersBox.Text = "All";
            this.allLayersBox.CheckedChanged += new DevComponents.DotNetBar.CheckBoxChangeEventHandler(this.allLayersBox_CheckedChanged);
            // 
            // viewOtherBar
            // 
            this.viewOtherBar.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.viewOtherBar.BackgroundMouseOverStyle.Class = "";
            this.viewOtherBar.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.viewOtherBar.BackgroundStyle.Class = "";
            this.viewOtherBar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.viewOtherBar.ContainerControlProcessDialogKey = true;
            this.viewOtherBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.viewOtherBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.showVR,
            this.showMinimap,
            this.emulateParallax});
            this.viewOtherBar.Location = new System.Drawing.Point(364, 0);
            this.viewOtherBar.Name = "viewOtherBar";
            this.viewOtherBar.Size = new System.Drawing.Size(243, 91);
            this.viewOtherBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.viewOtherBar.TabIndex = 1;
            this.viewOtherBar.Text = "Other";
            // 
            // 
            // 
            this.viewOtherBar.TitleStyle.Class = "";
            this.viewOtherBar.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.viewOtherBar.TitleStyleMouseOver.Class = "";
            this.viewOtherBar.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.viewOtherBar.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // viewMapObjsBar
            // 
            this.viewMapObjsBar.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.viewMapObjsBar.BackgroundMouseOverStyle.Class = "";
            this.viewMapObjsBar.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.viewMapObjsBar.BackgroundStyle.Class = "";
            this.viewMapObjsBar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.viewMapObjsBar.ContainerControlProcessDialogKey = true;
            this.viewMapObjsBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.viewMapObjsBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer7});
            this.viewMapObjsBar.Location = new System.Drawing.Point(3, 0);
            this.viewMapObjsBar.Name = "viewMapObjsBar";
            this.viewMapObjsBar.Size = new System.Drawing.Size(361, 91);
            this.viewMapObjsBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.viewMapObjsBar.TabIndex = 0;
            this.viewMapObjsBar.Text = "Map Objects";
            // 
            // 
            // 
            this.viewMapObjsBar.TitleStyle.Class = "";
            this.viewMapObjsBar.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.viewMapObjsBar.TitleStyleMouseOver.Class = "";
            this.viewMapObjsBar.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // itemContainer7
            // 
            // 
            // 
            // 
            this.itemContainer7.BackgroundStyle.Class = "";
            this.itemContainer7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer7.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer7.MultiLine = true;
            this.itemContainer7.Name = "itemContainer7";
            this.itemContainer7.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.viewTiles,
            this.viewObjs,
            this.viewNpcs,
            this.viewMobs,
            this.viewReactors,
            this.viewPortals,
            this.viewFhs,
            this.viewRopes,
            this.viewSeats,
            this.viewTooltips,
            this.viewBackgrounds});
            // 
            // viewTiles
            // 
            this.viewTiles.Checked = true;
            this.viewTiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.viewTiles.Name = "viewTiles";
            this.viewTiles.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.checkBoxItem1});
            this.viewTiles.Text = "Tiles";
            this.viewTiles.ThreeState = true;
            this.viewTiles.CheckedChanging += new DevComponents.DotNetBar.CheckBoxChangeEventHandler(this.viewCheckboxes_CheckedChanging);
            this.viewTiles.CheckedChanged += new DevComponents.DotNetBar.CheckBoxChangeEventHandler(this.viewCheckboxes_CheckedChanged);
            // 
            // checkBoxItem1
            // 
            this.checkBoxItem1.Name = "checkBoxItem1";
            this.checkBoxItem1.Text = "Tiles";
            // 
            // viewObjs
            // 
            this.viewObjs.Checked = true;
            this.viewObjs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.viewObjs.Name = "viewObjs";
            this.viewObjs.Text = "Objects";
            this.viewObjs.ThreeState = true;
            this.viewObjs.CheckedChanging += new DevComponents.DotNetBar.CheckBoxChangeEventHandler(this.viewCheckboxes_CheckedChanging);
            this.viewObjs.CheckedChanged += new DevComponents.DotNetBar.CheckBoxChangeEventHandler(this.viewCheckboxes_CheckedChanged);
            // 
            // viewNpcs
            // 
            this.viewNpcs.Checked = true;
            this.viewNpcs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.viewNpcs.Name = "viewNpcs";
            this.viewNpcs.Text = "NPCs";
            this.viewNpcs.ThreeState = true;
            this.viewNpcs.CheckedChanging += new DevComponents.DotNetBar.CheckBoxChangeEventHandler(this.viewCheckboxes_CheckedChanging);
            this.viewNpcs.CheckedChanged += new DevComponents.DotNetBar.CheckBoxChangeEventHandler(this.viewCheckboxes_CheckedChanged);
            // 
            // viewMobs
            // 
            this.viewMobs.Checked = true;
            this.viewMobs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.viewMobs.Name = "viewMobs";
            this.viewMobs.Text = "Mobs";
            this.viewMobs.ThreeState = true;
            this.viewMobs.CheckedChanging += new DevComponents.DotNetBar.CheckBoxChangeEventHandler(this.viewCheckboxes_CheckedChanging);
            this.viewMobs.CheckedChanged += new DevComponents.DotNetBar.CheckBoxChangeEventHandler(this.viewCheckboxes_CheckedChanged);
            // 
            // viewReactors
            // 
            this.viewReactors.Checked = true;
            this.viewReactors.CheckState = System.Windows.Forms.CheckState.Checked;
            this.viewReactors.Name = "viewReactors";
            this.viewReactors.Text = "Reactors";
            this.viewReactors.ThreeState = true;
            this.viewReactors.CheckedChanging += new DevComponents.DotNetBar.CheckBoxChangeEventHandler(this.viewCheckboxes_CheckedChanging);
            this.viewReactors.CheckedChanged += new DevComponents.DotNetBar.CheckBoxChangeEventHandler(this.viewCheckboxes_CheckedChanged);
            // 
            // viewPortals
            // 
            this.viewPortals.Checked = true;
            this.viewPortals.CheckState = System.Windows.Forms.CheckState.Checked;
            this.viewPortals.Name = "viewPortals";
            this.viewPortals.Text = "Portals";
            this.viewPortals.ThreeState = true;
            this.viewPortals.CheckedChanging += new DevComponents.DotNetBar.CheckBoxChangeEventHandler(this.viewCheckboxes_CheckedChanging);
            this.viewPortals.CheckedChanged += new DevComponents.DotNetBar.CheckBoxChangeEventHandler(this.viewCheckboxes_CheckedChanged);
            // 
            // viewFhs
            // 
            this.viewFhs.Name = "viewFhs";
            this.viewFhs.Text = "Footholds";
            this.viewFhs.ThreeState = true;
            this.viewFhs.CheckedChanging += new DevComponents.DotNetBar.CheckBoxChangeEventHandler(this.viewCheckboxes_CheckedChanging);
            this.viewFhs.CheckedChanged += new DevComponents.DotNetBar.CheckBoxChangeEventHandler(this.viewCheckboxes_CheckedChanged);
            // 
            // viewRopes
            // 
            this.viewRopes.Name = "viewRopes";
            this.viewRopes.Text = "Ropes";
            this.viewRopes.ThreeState = true;
            this.viewRopes.CheckedChanging += new DevComponents.DotNetBar.CheckBoxChangeEventHandler(this.viewCheckboxes_CheckedChanging);
            this.viewRopes.CheckedChanged += new DevComponents.DotNetBar.CheckBoxChangeEventHandler(this.viewCheckboxes_CheckedChanged);
            // 
            // viewSeats
            // 
            this.viewSeats.Name = "viewSeats";
            this.viewSeats.Text = "Chairs";
            this.viewSeats.ThreeState = true;
            this.viewSeats.CheckedChanging += new DevComponents.DotNetBar.CheckBoxChangeEventHandler(this.viewCheckboxes_CheckedChanging);
            this.viewSeats.CheckedChanged += new DevComponents.DotNetBar.CheckBoxChangeEventHandler(this.viewCheckboxes_CheckedChanged);
            // 
            // viewTooltips
            // 
            this.viewTooltips.Name = "viewTooltips";
            this.viewTooltips.Text = "Tooltips";
            this.viewTooltips.ThreeState = true;
            this.viewTooltips.CheckedChanging += new DevComponents.DotNetBar.CheckBoxChangeEventHandler(this.viewCheckboxes_CheckedChanging);
            this.viewTooltips.CheckedChanged += new DevComponents.DotNetBar.CheckBoxChangeEventHandler(this.viewCheckboxes_CheckedChanged);
            // 
            // viewBackgrounds
            // 
            this.viewBackgrounds.Name = "viewBackgrounds";
            this.viewBackgrounds.Text = "Backgrounds";
            this.viewBackgrounds.ThreeState = true;
            this.viewBackgrounds.CheckedChanging += new DevComponents.DotNetBar.CheckBoxChangeEventHandler(this.viewCheckboxes_CheckedChanging);
            this.viewBackgrounds.CheckedChanged += new DevComponents.DotNetBar.CheckBoxChangeEventHandler(this.viewCheckboxes_CheckedChanged);
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel3.Controls.Add(this.ribbonBar5);
            this.ribbonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel3.Location = new System.Drawing.Point(0, 56);
            this.ribbonPanel3.Name = "ribbonPanel3";
            this.ribbonPanel3.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel3.Size = new System.Drawing.Size(931, 94);
            // 
            // 
            // 
            this.ribbonPanel3.Style.Class = "";
            this.ribbonPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel3.StyleMouseDown.Class = "";
            this.ribbonPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel3.StyleMouseOver.Class = "";
            this.ribbonPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel3.TabIndex = 3;
            this.ribbonPanel3.Visible = false;
            // 
            // ribbonBar5
            // 
            this.ribbonBar5.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar5.BackgroundMouseOverStyle.Class = "";
            this.ribbonBar5.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar5.BackgroundStyle.Class = "";
            this.ribbonBar5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar5.ContainerControlProcessDialogKey = true;
            this.ribbonBar5.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar5.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer10});
            this.ribbonBar5.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar5.Name = "ribbonBar5";
            this.ribbonBar5.Size = new System.Drawing.Size(509, 91);
            this.ribbonBar5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar5.TabIndex = 0;
            this.ribbonBar5.Text = "Options";
            // 
            // 
            // 
            this.ribbonBar5.TitleStyle.Class = "";
            this.ribbonBar5.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar5.TitleStyleMouseOver.Class = "";
            this.ribbonBar5.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar5.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // itemContainer10
            // 
            // 
            // 
            // 
            this.itemContainer10.BackgroundStyle.Class = "";
            this.itemContainer10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer10.Name = "itemContainer10";
            this.itemContainer10.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.settingsButton,
            this.mapSimulatorButton,
            this.btnHaRepacker,
            this.regenMinimap,
            this.snapButton,
            this.randomTiles,
            this.buttonItem2});
            this.itemContainer10.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // buttonItem2
            // 
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.Text = "buttonItem2";
            this.buttonItem2.Click += new System.EventHandler(this.buttonItem2_Click);
            // 
            // viewTab
            // 
            this.viewTab.Checked = true;
            this.viewTab.Name = "viewTab";
            this.viewTab.Panel = this.ribbonPanel2;
            this.viewTab.Text = "View";
            // 
            // Tools
            // 
            this.Tools.Name = "Tools";
            this.Tools.Panel = this.ribbonPanel3;
            this.Tools.Text = "Tools";
            // 
            // itemContainer9
            // 
            // 
            // 
            // 
            this.itemContainer9.BackgroundStyle.Class = "";
            this.itemContainer9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer9.Name = "itemContainer9";
            this.itemContainer9.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.fhsEditMode,
            this.ropeEditMode,
            this.chairsEditMode,
            this.tooltipsEditMode});
            this.itemContainer9.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // fhsEditMode
            // 
            this.fhsEditMode.Name = "fhsEditMode";
            // 
            // ropeEditMode
            // 
            this.ropeEditMode.Name = "ropeEditMode";
            // 
            // chairsEditMode
            // 
            this.chairsEditMode.Name = "chairsEditMode";
            // 
            // tooltipsEditMode
            // 
            this.tooltipsEditMode.Name = "tooltipsEditMode";
            // 
            // itemContainer6
            // 
            // 
            // 
            // 
            this.itemContainer6.BackgroundStyle.Class = "";
            this.itemContainer6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer6.Name = "itemContainer6";
            this.itemContainer6.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tilesEditMode,
            this.objsEditMode,
            this.npcsEditMode,
            this.mobEditMode,
            this.reactEditMode,
            this.portalEditMode});
            this.itemContainer6.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // tilesEditMode
            // 
            this.tilesEditMode.Name = "tilesEditMode";
            // 
            // objsEditMode
            // 
            this.objsEditMode.Name = "objsEditMode";
            // 
            // npcsEditMode
            // 
            this.npcsEditMode.Name = "npcsEditMode";
            // 
            // mobEditMode
            // 
            this.mobEditMode.Name = "mobEditMode";
            // 
            // reactEditMode
            // 
            this.reactEditMode.Name = "reactEditMode";
            // 
            // portalEditMode
            // 
            this.portalEditMode.Name = "portalEditMode";
            // 
            // qatCustomizeItem1
            // 
            this.qatCustomizeItem1.Name = "qatCustomizeItem1";
            // 
            // cordsLabel
            // 
            this.cordsLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cordsLabel.Name = "cordsLabel";
            this.cordsLabel.Size = new System.Drawing.Size(36, 22);
            this.cordsLabel.Text = "cords";
            // 
            // statusStrip
            // 
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cordsLabel,
            this.itemDescLabel});
            this.statusStrip.Location = new System.Drawing.Point(85, 443);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip.Size = new System.Drawing.Size(778, 25);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "toolStrip2";
            // 
            // itemDescLabel
            // 
            this.itemDescLabel.Name = "itemDescLabel";
            this.itemDescLabel.Size = new System.Drawing.Size(31, 22);
            this.itemDescLabel.Text = "desc";
            // 
            // styleManager
            // 
            this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue;
            // 
            // dotNetBarManager
            // 
            this.dotNetBarManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.F1);
            this.dotNetBarManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlC);
            this.dotNetBarManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA);
            this.dotNetBarManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlV);
            this.dotNetBarManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlX);
            this.dotNetBarManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlZ);
            this.dotNetBarManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlY);
            this.dotNetBarManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Del);
            this.dotNetBarManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Ins);
            this.dotNetBarManager.BottomDockSite = this.dockSite4;
            this.dotNetBarManager.LeftDockSite = this.dockSite1;
            this.dotNetBarManager.ParentForm = this;
            this.dotNetBarManager.RightDockSite = this.dockSite2;
            this.dotNetBarManager.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dotNetBarManager.ToolbarBottomDockSite = this.dockSite8;
            this.dotNetBarManager.ToolbarLeftDockSite = this.dockSite5;
            this.dotNetBarManager.ToolbarRightDockSite = this.dockSite6;
            this.dotNetBarManager.ToolbarTopDockSite = this.dockSite7;
            this.dotNetBarManager.TopDockSite = this.dockSite3;
            // 
            // dockSite4
            // 
            this.dockSite4.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dockSite4.Location = new System.Drawing.Point(5, 468);
            this.dockSite4.Name = "dockSite4";
            this.dockSite4.Size = new System.Drawing.Size(969, 0);
            this.dockSite4.TabIndex = 9;
            this.dockSite4.TabStop = false;
            // 
            // dockSite1
            // 
            this.dockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite1.Controls.Add(this.bar1);
            this.dockSite1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dockSite1.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer(new DevComponents.DotNetBar.DocumentBaseContainer[] {
            ((DevComponents.DotNetBar.DocumentBaseContainer)(new DevComponents.DotNetBar.DocumentBarContainer(this.bar1, 77, 467)))}, DevComponents.DotNetBar.eOrientation.Horizontal);
            this.dockSite1.Location = new System.Drawing.Point(5, 1);
            this.dockSite1.Name = "dockSite1";
            this.dockSite1.Size = new System.Drawing.Size(80, 467);
            this.dockSite1.TabIndex = 6;
            this.dockSite1.TabStop = false;
            // 
            // bar1
            // 
            this.bar1.AccessibleDescription = "DotNetBar Bar (bar1)";
            this.bar1.AccessibleName = "DotNetBar Bar";
            this.bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.bar1.AutoSyncBarCaption = true;
            this.bar1.CloseSingleTab = true;
            this.bar1.Controls.Add(this.panelDockContainer7);
            this.bar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bar1.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Caption;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.dockContainerItem3});
            this.bar1.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer;
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(77, 467);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 0;
            this.bar1.TabStop = false;
            this.bar1.Text = "dockContainerItem3";
            // 
            // panelDockContainer7
            // 
            this.panelDockContainer7.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelDockContainer7.Location = new System.Drawing.Point(3, 23);
            this.panelDockContainer7.Name = "panelDockContainer7";
            this.panelDockContainer7.Size = new System.Drawing.Size(71, 441);
            this.panelDockContainer7.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelDockContainer7.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelDockContainer7.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelDockContainer7.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelDockContainer7.Style.GradientAngle = 90;
            this.panelDockContainer7.TabIndex = 0;
            // 
            // dockContainerItem3
            // 
            this.dockContainerItem3.Control = this.panelDockContainer7;
            this.dockContainerItem3.Name = "dockContainerItem3";
            this.dockContainerItem3.Text = "dockContainerItem3";
            // 
            // dockSite2
            // 
            this.dockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite2.Controls.Add(this.dockBar);
            this.dockSite2.Controls.Add(this.bar2);
            this.dockSite2.Dock = System.Windows.Forms.DockStyle.Right;
            this.dockSite2.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer(new DevComponents.DotNetBar.DocumentBaseContainer[] {
            ((DevComponents.DotNetBar.DocumentBaseContainer)(new DevComponents.DotNetBar.DocumentBarContainer(this.bar2, 108, 467)))}, DevComponents.DotNetBar.eOrientation.Horizontal);
            this.dockSite2.Location = new System.Drawing.Point(863, 1);
            this.dockSite2.Name = "dockSite2";
            this.dockSite2.Size = new System.Drawing.Size(111, 467);
            this.dockSite2.TabIndex = 7;
            this.dockSite2.TabStop = false;
            // 
            // dockBar
            // 
            this.dockBar.AccessibleDescription = "DotNetBar Bar (dockBar)";
            this.dockBar.AccessibleName = "DotNetBar Bar";
            this.dockBar.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.dockBar.AutoSyncBarCaption = true;
            this.dockBar.CloseSingleTab = true;
            this.dockBar.Controls.Add(this.panelDockContainer2);
            this.dockBar.Controls.Add(this.panelDockContainer4);
            this.dockBar.Controls.Add(this.panelDockContainer3);
            this.dockBar.Controls.Add(this.panelDockContainer5);
            this.dockBar.Controls.Add(this.panelDockContainer6);
            this.dockBar.Controls.Add(this.panelDockContainer1);
            this.dockBar.DockOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.dockBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dockBar.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Caption;
            this.dockBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tileDockBox,
            this.objsDockBox,
            this.bgDockBox,
            this.lifeDockBox,
            this.portalDockBox,
            this.objDockBox});
            this.dockBar.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer;
            this.dockBar.Location = new System.Drawing.Point(0, 0);
            this.dockBar.Name = "dockBar";
            this.dockBar.SelectedDockTab = 1;
            this.dockBar.Size = new System.Drawing.Size(38, 467);
            this.dockBar.Stretch = true;
            this.dockBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dockBar.TabIndex = 0;
            this.dockBar.TabStop = false;
            this.dockBar.Text = "Objects";
            // 
            // panelDockContainer1
            // 
            this.panelDockContainer1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelDockContainer1.Controls.Add(this.splitContainer1);
            this.panelDockContainer1.Location = new System.Drawing.Point(3, 23);
            this.panelDockContainer1.Name = "panelDockContainer1";
            this.panelDockContainer1.Size = new System.Drawing.Size(32, 416);
            this.panelDockContainer1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelDockContainer1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelDockContainer1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelDockContainer1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelDockContainer1.Style.GradientAngle = 90;
            this.panelDockContainer1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tileImagesContainer);
            this.splitContainer1.Size = new System.Drawing.Size(32, 416);
            this.splitContainer1.SplitterDistance = 117;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tileBrowse);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tileSetList);
            this.splitContainer2.Size = new System.Drawing.Size(32, 117);
            this.splitContainer2.SplitterDistance = 25;
            this.splitContainer2.TabIndex = 1;
            // 
            // tileBrowse
            // 
            this.tileBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileBrowse.Location = new System.Drawing.Point(0, 0);
            this.tileBrowse.Name = "tileBrowse";
            this.tileBrowse.Size = new System.Drawing.Size(32, 25);
            this.tileBrowse.TabIndex = 0;
            this.tileBrowse.Text = "Browse...";
            this.tileBrowse.UseVisualStyleBackColor = true;
            this.tileBrowse.Click += new System.EventHandler(this.tileBrowse_Click);
            // 
            // tileSetList
            // 
            this.tileSetList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileSetList.FormattingEnabled = true;
            this.tileSetList.Location = new System.Drawing.Point(0, 0);
            this.tileSetList.Name = "tileSetList";
            this.tileSetList.Size = new System.Drawing.Size(32, 88);
            this.tileSetList.TabIndex = 0;
            this.tileSetList.SelectedIndexChanged += new System.EventHandler(this.tileSetList_SelectedIndexChanged);
            // 
            // tileImagesContainer
            // 
            this.tileImagesContainer.AutoScroll = true;
            this.tileImagesContainer.BackColor = System.Drawing.Color.White;
            this.tileImagesContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileImagesContainer.Location = new System.Drawing.Point(0, 0);
            this.tileImagesContainer.Name = "tileImagesContainer";
            this.tileImagesContainer.Size = new System.Drawing.Size(32, 295);
            this.tileImagesContainer.TabIndex = 0;
            // 
            // panelDockContainer4
            // 
            this.panelDockContainer4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelDockContainer4.Controls.Add(this.splitContainer6);
            this.panelDockContainer4.Location = new System.Drawing.Point(3, 23);
            this.panelDockContainer4.Name = "panelDockContainer4";
            this.panelDockContainer4.Size = new System.Drawing.Size(32, 416);
            this.panelDockContainer4.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelDockContainer4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelDockContainer4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelDockContainer4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelDockContainer4.Style.GradientAngle = 90;
            this.panelDockContainer4.TabIndex = 4;
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.Location = new System.Drawing.Point(0, 0);
            this.splitContainer6.Name = "splitContainer6";
            this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.splitContainer7);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.bgImageContainer);
            this.splitContainer6.Size = new System.Drawing.Size(32, 416);
            this.splitContainer6.SplitterDistance = 103;
            this.splitContainer6.TabIndex = 0;
            // 
            // splitContainer7
            // 
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.Location = new System.Drawing.Point(0, 0);
            this.splitContainer7.Name = "splitContainer7";
            this.splitContainer7.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.Controls.Add(this.bgSetListBox);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.bgBack);
            this.splitContainer7.Panel2.Controls.Add(this.aniBg);
            this.splitContainer7.Panel2MinSize = 20;
            this.splitContainer7.Size = new System.Drawing.Size(32, 103);
            this.splitContainer7.SplitterDistance = 74;
            this.splitContainer7.TabIndex = 1;
            // 
            // bgSetListBox
            // 
            this.bgSetListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bgSetListBox.FormattingEnabled = true;
            this.bgSetListBox.Location = new System.Drawing.Point(0, 0);
            this.bgSetListBox.Name = "bgSetListBox";
            this.bgSetListBox.Size = new System.Drawing.Size(32, 74);
            this.bgSetListBox.TabIndex = 0;
            this.bgSetListBox.SelectedIndexChanged += new System.EventHandler(this.bgSetListBox_SelectedIndexChanged);
            // 
            // bgBack
            // 
            // 
            // 
            // 
            this.bgBack.BackgroundStyle.Class = "";
            this.bgBack.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.bgBack.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.bgBack.Checked = true;
            this.bgBack.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bgBack.CheckValue = "Y";
            this.bgBack.Location = new System.Drawing.Point(120, 3);
            this.bgBack.Name = "bgBack";
            this.bgBack.Size = new System.Drawing.Size(49, 18);
            this.bgBack.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bgBack.TabIndex = 1;
            this.bgBack.Text = "Static";
            this.bgBack.CheckedChanged += new System.EventHandler(this.bgSetListBox_SelectedIndexChanged);
            // 
            // aniBg
            // 
            // 
            // 
            // 
            this.aniBg.BackgroundStyle.Class = "";
            this.aniBg.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.aniBg.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.aniBg.Location = new System.Drawing.Point(3, 3);
            this.aniBg.Name = "aniBg";
            this.aniBg.Size = new System.Drawing.Size(67, 18);
            this.aniBg.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.aniBg.TabIndex = 0;
            this.aniBg.Text = "Animated";
            this.aniBg.CheckedChanged += new System.EventHandler(this.bgSetListBox_SelectedIndexChanged);
            // 
            // bgImageContainer
            // 
            this.bgImageContainer.AutoScroll = true;
            this.bgImageContainer.BackColor = System.Drawing.Color.White;
            this.bgImageContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bgImageContainer.Location = new System.Drawing.Point(0, 0);
            this.bgImageContainer.Name = "bgImageContainer";
            this.bgImageContainer.Size = new System.Drawing.Size(32, 309);
            this.bgImageContainer.TabIndex = 0;
            // 
            // panelDockContainer3
            // 
            this.panelDockContainer3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelDockContainer3.Controls.Add(this.splitContainer8);
            this.panelDockContainer3.Location = new System.Drawing.Point(3, 23);
            this.panelDockContainer3.Name = "panelDockContainer3";
            this.panelDockContainer3.Size = new System.Drawing.Size(32, 416);
            this.panelDockContainer3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelDockContainer3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelDockContainer3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelDockContainer3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelDockContainer3.Style.GradientAngle = 90;
            this.panelDockContainer3.TabIndex = 2;
            // 
            // splitContainer8
            // 
            this.splitContainer8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer8.Location = new System.Drawing.Point(0, 0);
            this.splitContainer8.Name = "splitContainer8";
            this.splitContainer8.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer8.Panel1
            // 
            this.splitContainer8.Panel1.Controls.Add(this.splitContainer9);
            // 
            // splitContainer8.Panel2
            // 
            this.splitContainer8.Panel2.AutoScroll = true;
            this.splitContainer8.Panel2.Controls.Add(this.lifePictureBox);
            this.splitContainer8.Size = new System.Drawing.Size(32, 416);
            this.splitContainer8.SplitterDistance = 142;
            this.splitContainer8.TabIndex = 0;
            // 
            // splitContainer9
            // 
            this.splitContainer9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer9.Location = new System.Drawing.Point(0, 0);
            this.splitContainer9.Name = "splitContainer9";
            this.splitContainer9.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer9.Panel1
            // 
            this.splitContainer9.Panel1.Controls.Add(this.labelX1);
            this.splitContainer9.Panel1.Controls.Add(this.lifeSearchBox);
            this.splitContainer9.Panel1.Controls.Add(this.mobRButton);
            this.splitContainer9.Panel1.Controls.Add(this.npcRButton);
            this.splitContainer9.Panel1.Controls.Add(this.reactorRButton);
            // 
            // splitContainer9.Panel2
            // 
            this.splitContainer9.Panel2.Controls.Add(this.lifeListBox);
            this.splitContainer9.Size = new System.Drawing.Size(32, 142);
            this.splitContainer9.SplitterDistance = 52;
            this.splitContainer9.TabIndex = 3;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(3, 30);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(37, 15);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "Search";
            // 
            // lifeSearchBox
            // 
            // 
            // 
            // 
            this.lifeSearchBox.Border.Class = "TextBoxBorder";
            this.lifeSearchBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lifeSearchBox.Location = new System.Drawing.Point(44, 28);
            this.lifeSearchBox.Name = "lifeSearchBox";
            this.lifeSearchBox.Size = new System.Drawing.Size(146, 20);
            this.lifeSearchBox.TabIndex = 3;
            this.lifeSearchBox.TextChanged += new System.EventHandler(this.lifeSearchBox_TextChanged);
            // 
            // mobRButton
            // 
            // 
            // 
            // 
            this.mobRButton.BackgroundStyle.Class = "";
            this.mobRButton.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mobRButton.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.mobRButton.Checked = true;
            this.mobRButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mobRButton.CheckValue = "Y";
            this.mobRButton.Location = new System.Drawing.Point(3, 3);
            this.mobRButton.Name = "mobRButton";
            this.mobRButton.Size = new System.Drawing.Size(42, 19);
            this.mobRButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.mobRButton.TabIndex = 1;
            this.mobRButton.Text = "Mob";
            this.mobRButton.CheckedChanged += new System.EventHandler(this.lifeModeChanged);
            // 
            // npcRButton
            // 
            // 
            // 
            // 
            this.npcRButton.BackgroundStyle.Class = "";
            this.npcRButton.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.npcRButton.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.npcRButton.Location = new System.Drawing.Point(51, 3);
            this.npcRButton.Name = "npcRButton";
            this.npcRButton.Size = new System.Drawing.Size(41, 19);
            this.npcRButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.npcRButton.TabIndex = 2;
            this.npcRButton.Text = "NPC";
            this.npcRButton.CheckedChanged += new System.EventHandler(this.lifeModeChanged);
            // 
            // reactorRButton
            // 
            // 
            // 
            // 
            this.reactorRButton.BackgroundStyle.Class = "";
            this.reactorRButton.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reactorRButton.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.reactorRButton.Location = new System.Drawing.Point(98, 3);
            this.reactorRButton.Name = "reactorRButton";
            this.reactorRButton.Size = new System.Drawing.Size(67, 19);
            this.reactorRButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.reactorRButton.TabIndex = 0;
            this.reactorRButton.Text = "Reactor";
            this.reactorRButton.CheckedChanged += new System.EventHandler(this.lifeModeChanged);
            // 
            // lifeListBox
            // 
            this.lifeListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lifeListBox.FormattingEnabled = true;
            this.lifeListBox.Location = new System.Drawing.Point(0, 0);
            this.lifeListBox.Name = "lifeListBox";
            this.lifeListBox.Size = new System.Drawing.Size(32, 86);
            this.lifeListBox.TabIndex = 0;
            this.lifeListBox.SelectedValueChanged += new System.EventHandler(this.lifeListBox_SelectedValueChanged);
            // 
            // panelDockContainer5
            // 
            this.panelDockContainer5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelDockContainer5.Controls.Add(this.portalImageContainer);
            this.panelDockContainer5.Location = new System.Drawing.Point(3, 23);
            this.panelDockContainer5.Name = "panelDockContainer5";
            this.panelDockContainer5.Size = new System.Drawing.Size(32, 416);
            this.panelDockContainer5.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelDockContainer5.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelDockContainer5.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelDockContainer5.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelDockContainer5.Style.GradientAngle = 90;
            this.panelDockContainer5.TabIndex = 9;
            // 
            // portalImageContainer
            // 
            this.portalImageContainer.AutoScroll = true;
            this.portalImageContainer.BackColor = System.Drawing.Color.White;
            this.portalImageContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.portalImageContainer.Location = new System.Drawing.Point(0, 0);
            this.portalImageContainer.Name = "portalImageContainer";
            this.portalImageContainer.Size = new System.Drawing.Size(32, 416);
            this.portalImageContainer.TabIndex = 0;
            // 
            // panelDockContainer6
            // 
            this.panelDockContainer6.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelDockContainer6.Controls.Add(this.miscItemsContainer);
            this.panelDockContainer6.Location = new System.Drawing.Point(3, 23);
            this.panelDockContainer6.Name = "panelDockContainer6";
            this.panelDockContainer6.Size = new System.Drawing.Size(32, 416);
            this.panelDockContainer6.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelDockContainer6.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelDockContainer6.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelDockContainer6.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelDockContainer6.Style.GradientAngle = 90;
            this.panelDockContainer6.TabIndex = 7;
            // 
            // miscItemsContainer
            // 
            this.miscItemsContainer.BackColor = System.Drawing.Color.White;
            this.miscItemsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.miscItemsContainer.Location = new System.Drawing.Point(0, 0);
            this.miscItemsContainer.Name = "miscItemsContainer";
            this.miscItemsContainer.Size = new System.Drawing.Size(32, 416);
            this.miscItemsContainer.TabIndex = 0;
            // 
            // panelDockContainer2
            // 
            this.panelDockContainer2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelDockContainer2.Controls.Add(this.splitContainer3);
            this.panelDockContainer2.Location = new System.Drawing.Point(3, 23);
            this.panelDockContainer2.Name = "panelDockContainer2";
            this.panelDockContainer2.Size = new System.Drawing.Size(32, 416);
            this.panelDockContainer2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelDockContainer2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelDockContainer2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelDockContainer2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelDockContainer2.Style.GradientAngle = 90;
            this.panelDockContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer5);
            this.splitContainer3.Size = new System.Drawing.Size(32, 416);
            this.splitContainer3.SplitterDistance = 121;
            this.splitContainer3.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.objSetListBox);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.objL0ListBox);
            this.splitContainer4.Size = new System.Drawing.Size(32, 121);
            this.splitContainer4.SplitterDistance = 74;
            this.splitContainer4.TabIndex = 0;
            // 
            // objSetListBox
            // 
            this.objSetListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objSetListBox.FormattingEnabled = true;
            this.objSetListBox.Location = new System.Drawing.Point(0, 0);
            this.objSetListBox.Name = "objSetListBox";
            this.objSetListBox.Size = new System.Drawing.Size(32, 74);
            this.objSetListBox.TabIndex = 0;
            this.objSetListBox.SelectedIndexChanged += new System.EventHandler(this.objSetListBox_SelectedIndexChanged);
            // 
            // objL0ListBox
            // 
            this.objL0ListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objL0ListBox.FormattingEnabled = true;
            this.objL0ListBox.Location = new System.Drawing.Point(0, 0);
            this.objL0ListBox.Name = "objL0ListBox";
            this.objL0ListBox.Size = new System.Drawing.Size(32, 43);
            this.objL0ListBox.TabIndex = 0;
            this.objL0ListBox.SelectedIndexChanged += new System.EventHandler(this.objL0ListBox_SelectedIndexChanged);
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.objL1ListBox);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.objImagesContainer);
            this.splitContainer5.Size = new System.Drawing.Size(32, 291);
            this.splitContainer5.SplitterDistance = 43;
            this.splitContainer5.TabIndex = 0;
            // 
            // objL1ListBox
            // 
            this.objL1ListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objL1ListBox.FormattingEnabled = true;
            this.objL1ListBox.Location = new System.Drawing.Point(0, 0);
            this.objL1ListBox.Name = "objL1ListBox";
            this.objL1ListBox.Size = new System.Drawing.Size(32, 43);
            this.objL1ListBox.TabIndex = 0;
            this.objL1ListBox.SelectedIndexChanged += new System.EventHandler(this.objL1ListBox_SelectedIndexChanged);
            // 
            // objImagesContainer
            // 
            this.objImagesContainer.AutoScroll = true;
            this.objImagesContainer.BackColor = System.Drawing.Color.White;
            this.objImagesContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objImagesContainer.Location = new System.Drawing.Point(0, 0);
            this.objImagesContainer.Name = "objImagesContainer";
            this.objImagesContainer.Size = new System.Drawing.Size(32, 244);
            this.objImagesContainer.TabIndex = 0;
            // 
            // tileDockBox
            // 
            this.tileDockBox.Control = this.panelDockContainer1;
            this.tileDockBox.Name = "tileDockBox";
            this.tileDockBox.Text = "Tiles";
            // 
            // objsDockBox
            // 
            this.objsDockBox.Control = this.panelDockContainer2;
            this.objsDockBox.Name = "objsDockBox";
            this.objsDockBox.Text = "Objects";
            // 
            // bgDockBox
            // 
            this.bgDockBox.Control = this.panelDockContainer4;
            this.bgDockBox.Name = "bgDockBox";
            this.bgDockBox.Text = "Background";
            // 
            // lifeDockBox
            // 
            this.lifeDockBox.Control = this.panelDockContainer3;
            this.lifeDockBox.Name = "lifeDockBox";
            this.lifeDockBox.Text = "Life";
            // 
            // portalDockBox
            // 
            this.portalDockBox.Control = this.panelDockContainer5;
            this.portalDockBox.Name = "portalDockBox";
            this.portalDockBox.Text = "Portal";
            // 
            // dockContainerItem2
            // 
            this.objDockBox.Control = this.panelDockContainer6;
            this.objDockBox.Name = "dockContainerItem2";
            this.objDockBox.Text = "Misc";
            // 
            // bar2
            // 
            this.bar2.AccessibleDescription = "DotNetBar Bar (bar2)";
            this.bar2.AccessibleName = "DotNetBar Bar";
            this.bar2.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.bar2.AutoSyncBarCaption = true;
            this.bar2.CloseSingleTab = true;
            this.bar2.Controls.Add(this.panelDockContainer8);
            this.bar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bar2.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Caption;
            this.bar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.dockContainerItem4});
            this.bar2.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer;
            this.bar2.Location = new System.Drawing.Point(3, 0);
            this.bar2.Name = "bar2";
            this.bar2.Size = new System.Drawing.Size(108, 467);
            this.bar2.Stretch = true;
            this.bar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar2.TabIndex = 1;
            this.bar2.TabStop = false;
            this.bar2.Text = "dockContainerItem4";
            // 
            // panelDockContainer8
            // 
            this.panelDockContainer8.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelDockContainer8.Location = new System.Drawing.Point(3, 23);
            this.panelDockContainer8.Name = "panelDockContainer8";
            this.panelDockContainer8.Size = new System.Drawing.Size(102, 441);
            this.panelDockContainer8.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelDockContainer8.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelDockContainer8.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelDockContainer8.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelDockContainer8.Style.GradientAngle = 90;
            this.panelDockContainer8.TabIndex = 0;
            // 
            // dockContainerItem4
            // 
            this.dockContainerItem4.Control = this.panelDockContainer8;
            this.dockContainerItem4.Name = "dockContainerItem4";
            this.dockContainerItem4.Text = "dockContainerItem4";
            // 
            // dockSite8
            // 
            this.dockSite8.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dockSite8.Location = new System.Drawing.Point(5, 468);
            this.dockSite8.Name = "dockSite8";
            this.dockSite8.Size = new System.Drawing.Size(969, 0);
            this.dockSite8.TabIndex = 13;
            this.dockSite8.TabStop = false;
            // 
            // dockSite5
            // 
            this.dockSite5.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite5.Dock = System.Windows.Forms.DockStyle.Left;
            this.dockSite5.Location = new System.Drawing.Point(5, 1);
            this.dockSite5.Name = "dockSite5";
            this.dockSite5.Size = new System.Drawing.Size(0, 467);
            this.dockSite5.TabIndex = 10;
            this.dockSite5.TabStop = false;
            // 
            // dockSite6
            // 
            this.dockSite6.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite6.Dock = System.Windows.Forms.DockStyle.Right;
            this.dockSite6.Location = new System.Drawing.Point(974, 1);
            this.dockSite6.Name = "dockSite6";
            this.dockSite6.Size = new System.Drawing.Size(0, 467);
            this.dockSite6.TabIndex = 11;
            this.dockSite6.TabStop = false;
            // 
            // dockSite7
            // 
            this.dockSite7.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite7.Dock = System.Windows.Forms.DockStyle.Top;
            this.dockSite7.Location = new System.Drawing.Point(5, 1);
            this.dockSite7.Name = "dockSite7";
            this.dockSite7.Size = new System.Drawing.Size(969, 0);
            this.dockSite7.TabIndex = 12;
            this.dockSite7.TabStop = false;
            // 
            // dockSite3
            // 
            this.dockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite3.Dock = System.Windows.Forms.DockStyle.Top;
            this.dockSite3.Location = new System.Drawing.Point(5, 1);
            this.dockSite3.Name = "dockSite3";
            this.dockSite3.Size = new System.Drawing.Size(969, 0);
            this.dockSite3.TabIndex = 8;
            this.dockSite3.TabStop = false;
            // 
            // dockContainerItem1
            // 
            this.tileDockBox.Name = "dockContainerItem1";
            this.tileDockBox.Text = "Reactor";
            // 
            // Tabs
            // 
            this.Tabs.CurrentPage = null;
            this.Tabs.Location = new System.Drawing.Point(234, 200);
            this.Tabs.Name = "Tabs";
            this.Tabs.Size = new System.Drawing.Size(289, 236);
            this.Tabs.TabColor = System.Drawing.Color.LightSteelBlue;
            this.Tabs.TabIndex = 0;
            this.Tabs.TopMargin = 3;
            this.Tabs.CurrentPageChanged += new TabPages.PageCollection.CurrentPageChangedEventHandler(this.Tabs_CurrentPageChanged);
            this.Tabs.PageClosing += new TabPages.PageCollection.PageClosingEventHandler(this.Tabs_PageClosing);
            // 
            // multiBoard
            // 
            this.multiBoard.DeviceReady = false;
            this.multiBoard.Location = new System.Drawing.Point(439, 277);
            this.multiBoard.Name = "multiBoard";
            this.multiBoard.SelectedBoard = null;
            this.multiBoard.Size = new System.Drawing.Size(170, 114);
            this.multiBoard.TabIndex = 5;
            this.multiBoard.MouseMoved += new HaCreator.MapEditor.MultiBoard.MouseMovedDelegate(this.multiBoard_MouseMoved);
            this.multiBoard.OnUndoListChanged += new HaCreator.MapEditor.MultiBoard.UndoRedoDelegate(this.multiBoard_OnUndoListChanged);
            this.multiBoard.OnRedoListChanged += new HaCreator.MapEditor.MultiBoard.UndoRedoDelegate(this.multiBoard_OnRedoListChanged);
            this.multiBoard.OnLayerTSChanged += new HaCreator.MapEditor.MultiBoard.LayerTSChangedDelegate(this.multiBoard_OnLayerTSChanged);
            this.multiBoard.OnEditInstanceClicked += new HaCreator.MapEditor.MultiBoard.MenuItemClickedDelegate(this.multiBoard_OnEditInstanceClicked);
            this.multiBoard.OnEditBaseClicked += new HaCreator.MapEditor.MultiBoard.MenuItemClickedDelegate(this.multiBoard_OnEditBaseClicked);
            this.multiBoard.OnSendToBackClicked += new HaCreator.MapEditor.MultiBoard.MenuItemClickedDelegate(this.multiBoard_OnSendToBackClicked);
            this.multiBoard.OnBringToFrontClicked += new HaCreator.MapEditor.MultiBoard.MenuItemClickedDelegate(this.multiBoard_OnBringToFrontClicked);
            this.multiBoard.ReturnToSelectionState += new HaCreator.MapEditor.MultiBoard.ReturnToSelectionStateDelegate(this.multiBoard_ReturnToSelectionState);
            this.multiBoard.SelectedItemChanged += new HaCreator.MapEditor.MultiBoard.SelectedItemChangedDelegate(this.multiBoard_SelectedItemChanged);
            // 
            // showVR
            // 
            this.showVR.AutoCheckOnClick = true;
            this.showVR.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.showVR.Checked = true;
            this.showVR.Image = global::HaCreator.Properties.Resources.ShowVR;
            this.showVR.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.showVR.Name = "showVR";
            this.showVR.Text = "Show VR";
            this.showVR.Click += new System.EventHandler(this.showVR_Click);
            // 
            // showMinimap
            // 
            this.showMinimap.AutoCheckOnClick = true;
            this.showMinimap.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.showMinimap.Checked = true;
            this.showMinimap.Image = global::HaCreator.Properties.Resources.Minimap;
            this.showMinimap.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.showMinimap.Name = "showMinimap";
            this.showMinimap.Text = "Show Minimap";
            this.showMinimap.CheckedChanged += new System.EventHandler(this.showMinimap_CheckedChanged);
            // 
            // emulateParallax
            // 
            this.emulateParallax.AutoCheckOnClick = true;
            this.emulateParallax.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.emulateParallax.Checked = true;
            this.emulateParallax.Image = global::HaCreator.Properties.Resources.diagram_parallax;
            this.emulateParallax.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.emulateParallax.Name = "emulateParallax";
            this.emulateParallax.Text = "Parallax BGs";
            this.emulateParallax.CheckedChanged += new System.EventHandler(this.emulateParallax_CheckedChanged);
            // 
            // settingsButton
            // 
            this.settingsButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.settingsButton.Image = global::HaCreator.Properties.Resources.Settings_big;
            this.settingsButton.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.SubItemsExpandWidth = 14;
            this.settingsButton.Text = "Settings...";
            this.settingsButton.Click += new System.EventHandler(this.showSettingsForm);
            // 
            // mapSimulatorButton
            // 
            this.mapSimulatorButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.mapSimulatorButton.Image = global::HaCreator.Properties.Resources.Play_1_Hot_icon;
            this.mapSimulatorButton.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.mapSimulatorButton.Name = "mapSimulatorButton";
            this.mapSimulatorButton.Text = "Map Simulation";
            this.mapSimulatorButton.Click += new System.EventHandler(this.mapSimulatorButton_Click);
            // 
            // btnHaRepacker
            // 
            this.btnHaRepacker.Image = global::HaCreator.Properties.Resources.Sharingan32;
            this.btnHaRepacker.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnHaRepacker.Name = "btnHaRepacker";
            this.btnHaRepacker.Text = "Launch HaRepacker";
            this.btnHaRepacker.Click += new System.EventHandler(this.btnHaRepacker_Click);
            // 
            // regenMinimap
            // 
            this.regenMinimap.Image = global::HaCreator.Properties.Resources.RegenMinimap;
            this.regenMinimap.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.regenMinimap.Name = "regenMinimap";
            this.regenMinimap.Text = "Regenerate Minimap";
            this.regenMinimap.Click += new System.EventHandler(this.regenMinimap_Click);
            // 
            // snapButton
            // 
            this.snapButton.AutoCheckOnClick = true;
            this.snapButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.snapButton.Checked = true;
            this.snapButton.Image = global::HaCreator.Properties.Resources.magnet_32;
            this.snapButton.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.snapButton.Name = "snapButton";
            this.snapButton.Text = "Snapping";
            this.snapButton.Click += new System.EventHandler(this.snapButton_Click);
            // 
            // randomTiles
            // 
            this.randomTiles.AutoCheckOnClick = true;
            this.randomTiles.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.randomTiles.Checked = true;
            this.randomTiles.Image = global::HaCreator.Properties.Resources.Untitled_1;
            this.randomTiles.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.randomTiles.Name = "randomTiles";
            this.randomTiles.Text = "Random Tiles";
            this.randomTiles.CheckedChanged += new System.EventHandler(this.randomTiles_CheckedChanged);
            // 
            // StartButton
            // 
            this.StartButton.AutoExpandOnClick = true;
            this.StartButton.CanCustomize = false;
            this.StartButton.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            this.StartButton.Image = ((System.Drawing.Image)(resources.GetObject("StartButton.Image")));
            this.StartButton.ImagePaddingHorizontal = 2;
            this.StartButton.ImagePaddingVertical = 2;
            this.StartButton.Name = "StartButton";
            this.StartButton.ShowSubItems = false;
            this.StartButton.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer1});
            this.StartButton.Text = "&File";
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.Class = "RibbonFileMenuContainer";
            this.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer1.Name = "itemContainer1";
            this.itemContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer2,
            this.itemContainer5});
            // 
            // itemContainer2
            // 
            // 
            // 
            // 
            this.itemContainer2.BackgroundStyle.Class = "RibbonFileMenuTwoColumnContainer";
            this.itemContainer2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer2.ItemSpacing = 0;
            this.itemContainer2.Name = "itemContainer2";
            this.itemContainer2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer3,
            this.itemContainer4});
            // 
            // itemContainer3
            // 
            // 
            // 
            // 
            this.itemContainer3.BackgroundStyle.Class = "RibbonFileMenuColumnOneContainer";
            this.itemContainer3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer3.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer3.MinimumSize = new System.Drawing.Size(120, 0);
            this.itemContainer3.Name = "itemContainer3";
            this.itemContainer3.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.openButton,
            this.saveButton,
            this.buttonItem1,
            this.infoButton});
            // 
            // openButton
            // 
            this.openButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.openButton.Image = global::HaCreator.Properties.Resources.Folder;
            this.openButton.Name = "openButton";
            this.openButton.SubItemsExpandWidth = 24;
            this.openButton.Text = "&Open...";
            this.openButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.saveButton.Image = global::HaCreator.Properties.Resources.Save;
            this.saveButton.Name = "saveButton";
            this.saveButton.SubItemsExpandWidth = 24;
            this.saveButton.Text = "&Save";
            // 
            // buttonItem1
            // 
            this.buttonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem1.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItem1.Icon")));
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.SubItemsExpandWidth = 24;
            this.buttonItem1.Text = "&Repack WZ Files";
            // 
            // infoButton
            // 
            this.infoButton.BeginGroup = true;
            this.infoButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.infoButton.Image = global::HaCreator.Properties.Resources.About;
            this.infoButton.Name = "infoButton";
            this.infoButton.SubItemsExpandWidth = 24;
            this.infoButton.Text = "&About";
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // itemContainer4
            // 
            // 
            // 
            // 
            this.itemContainer4.BackgroundStyle.Class = "RibbonFileMenuColumnTwoContainer";
            this.itemContainer4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer4.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer4.MinimumSize = new System.Drawing.Size(180, 0);
            this.itemContainer4.Name = "itemContainer4";
            this.itemContainer4.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem8,
            this.buttonItem8,
            this.buttonItem9,
            this.buttonItem10,
            this.buttonItem11});
            this.itemContainer4.Visible = false;
            // 
            // labelItem8
            // 
            this.labelItem8.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.labelItem8.BorderType = DevComponents.DotNetBar.eBorderType.Etched;
            this.labelItem8.CanCustomize = false;
            this.labelItem8.Name = "labelItem8";
            this.labelItem8.PaddingBottom = 2;
            this.labelItem8.PaddingTop = 2;
            this.labelItem8.Stretch = true;
            this.labelItem8.Text = "Recent";
            // 
            // buttonItem8
            // 
            this.buttonItem8.Name = "buttonItem8";
            this.buttonItem8.Text = "&1. Short News 5-7.rtf";
            // 
            // buttonItem9
            // 
            this.buttonItem9.Name = "buttonItem9";
            this.buttonItem9.Text = "&2. Prospect Email.rtf";
            // 
            // buttonItem10
            // 
            this.buttonItem10.Name = "buttonItem10";
            this.buttonItem10.Text = "&3. Customer Email.rtf";
            // 
            // buttonItem11
            // 
            this.buttonItem11.Name = "buttonItem11";
            this.buttonItem11.Text = "&4. example.rtf";
            // 
            // itemContainer5
            // 
            // 
            // 
            // 
            this.itemContainer5.BackgroundStyle.Class = "RibbonFileMenuBottomContainer";
            this.itemContainer5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer5.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right;
            this.itemContainer5.Name = "itemContainer5";
            this.itemContainer5.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.settingsMenuButton,
            this.exitButton});
            // 
            // settingsMenuButton
            // 
            this.settingsMenuButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.settingsMenuButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.settingsMenuButton.Image = global::HaCreator.Properties.Resources.Settings;
            this.settingsMenuButton.Name = "settingsMenuButton";
            this.settingsMenuButton.SubItemsExpandWidth = 24;
            this.settingsMenuButton.Text = "Sett&ings";
            this.settingsMenuButton.Click += new System.EventHandler(this.showSettingsForm);
            // 
            // exitButton
            // 
            this.exitButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.exitButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.exitButton.Image = global::HaCreator.Properties.Resources.Exit;
            this.exitButton.Name = "exitButton";
            this.exitButton.SubItemsExpandWidth = 24;
            this.exitButton.Text = "E&xit";
            this.exitButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // undoButton
            // 
            this.undoButton.Enabled = false;
            this.undoButton.Image = global::HaCreator.Properties.Resources.Undo;
            this.undoButton.Name = "undoButton";
            this.undoButton.Text = "buttonItem1";
            this.undoButton.Tooltip = "Undo";
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // redoButton
            // 
            this.redoButton.Enabled = false;
            this.redoButton.Image = ((System.Drawing.Image)(resources.GetObject("redoButton.Image")));
            this.redoButton.Name = "redoButton";
            this.redoButton.Text = "buttonItem16";
            this.redoButton.Tooltip = "Redo";
            this.redoButton.Click += new System.EventHandler(this.redoButton_Click);
            // 
            // lifePictureBox
            // 
            this.lifePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lifePictureBox.Location = new System.Drawing.Point(0, 0);
            this.lifePictureBox.Name = "lifePictureBox";
            this.lifePictureBox.Size = new System.Drawing.Size(32, 270);
            this.lifePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.lifePictureBox.TabIndex = 0;
            this.lifePictureBox.TabStop = false;
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 470);
            this.Controls.Add(this.ribbonControl);
            this.Controls.Add(this.Tabs);
            this.Controls.Add(this.multiBoard);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.dockSite1);
            this.Controls.Add(this.dockSite2);
            this.Controls.Add(this.dockSite3);
            this.Controls.Add(this.dockSite4);
            this.Controls.Add(this.dockSite5);
            this.Controls.Add(this.dockSite6);
            this.Controls.Add(this.dockSite7);
            this.Controls.Add(this.dockSite8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Editor";
            this.Text = "HaCreator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Editor_FormClosing);
            this.Load += new System.EventHandler(this.Editor_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Editor_Paint);
            this.Resize += new System.EventHandler(this.Editor_Resize);
            this.ribbonControl.ResumeLayout(false);
            this.ribbonControl.PerformLayout();
            this.ribbonPanel2.ResumeLayout(false);
            this.ribbonPanel3.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.dockSite1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.bar1.ResumeLayout(false);
            this.dockSite2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dockBar)).EndInit();
            this.dockBar.ResumeLayout(false);
            this.panelDockContainer1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panelDockContainer4.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            this.panelDockContainer3.ResumeLayout(false);
            this.splitContainer8.Panel1.ResumeLayout(false);
            this.splitContainer8.Panel2.ResumeLayout(false);
            this.splitContainer8.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).EndInit();
            this.splitContainer8.ResumeLayout(false);
            this.splitContainer9.Panel1.ResumeLayout(false);
            this.splitContainer9.Panel1.PerformLayout();
            this.splitContainer9.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer9)).EndInit();
            this.splitContainer9.ResumeLayout(false);
            this.panelDockContainer5.ResumeLayout(false);
            this.panelDockContainer6.ResumeLayout(false);
            this.panelDockContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar2)).EndInit();
            this.bar2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lifePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.RibbonControl ribbonControl;
        private DevComponents.DotNetBar.Office2007StartButton StartButton;
        private DevComponents.DotNetBar.ButtonItem undoButton;
        private HaCreator.MapEditor.MultiBoard multiBoard;
        private TabPages.PageCollection Tabs;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.ItemContainer itemContainer2;
        private DevComponents.DotNetBar.ItemContainer itemContainer3;
        private DevComponents.DotNetBar.ButtonItem openButton;
        private DevComponents.DotNetBar.ButtonItem saveButton;
        private DevComponents.DotNetBar.ButtonItem infoButton;
        private DevComponents.DotNetBar.ItemContainer itemContainer4;
        private DevComponents.DotNetBar.LabelItem labelItem8;
        private DevComponents.DotNetBar.ButtonItem buttonItem8;
        private DevComponents.DotNetBar.ButtonItem buttonItem9;
        private DevComponents.DotNetBar.ButtonItem buttonItem10;
        private DevComponents.DotNetBar.ButtonItem buttonItem11;
        private DevComponents.DotNetBar.ItemContainer itemContainer5;
        private DevComponents.DotNetBar.ButtonItem settingsMenuButton;
        private DevComponents.DotNetBar.ButtonItem exitButton;
        private DevComponents.DotNetBar.ItemContainer itemContainer6;
        private DevComponents.DotNetBar.ButtonItem tilesEditMode;
        private DevComponents.DotNetBar.ButtonItem objsEditMode;
        private DevComponents.DotNetBar.ButtonItem npcsEditMode;
        private DevComponents.DotNetBar.ButtonItem mobEditMode;
        private DevComponents.DotNetBar.ButtonItem reactEditMode;
        private DevComponents.DotNetBar.ButtonItem portalEditMode;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel2;
        private DevComponents.DotNetBar.RibbonBar viewMapObjsBar;
        private DevComponents.DotNetBar.ItemContainer itemContainer7;
        private DevComponents.DotNetBar.CheckBoxItem viewTiles;
        private DevComponents.DotNetBar.CheckBoxItem checkBoxItem1;
        private DevComponents.DotNetBar.CheckBoxItem viewObjs;
        private DevComponents.DotNetBar.CheckBoxItem viewNpcs;
        private DevComponents.DotNetBar.CheckBoxItem viewMobs;
        private DevComponents.DotNetBar.RibbonTabItem viewTab;
        private DevComponents.DotNetBar.RibbonBar viewOtherBar;
        private DevComponents.DotNetBar.CheckBoxItem viewReactors;
        private DevComponents.DotNetBar.CheckBoxItem viewPortals;
        private DevComponents.DotNetBar.CheckBoxItem viewFhs;
        private DevComponents.DotNetBar.CheckBoxItem viewRopes;
        private DevComponents.DotNetBar.CheckBoxItem viewSeats;
        private DevComponents.DotNetBar.CheckBoxItem viewTooltips;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel3;
        private DevComponents.DotNetBar.RibbonTabItem Tools;
        private DevComponents.DotNetBar.RibbonBar ribbonBar5;
        private DevComponents.DotNetBar.ButtonItem settingsButton;
        private DevComponents.DotNetBar.ButtonItem snapButton;
        private DevComponents.DotNetBar.ButtonItem showVR;
        private DevComponents.DotNetBar.ButtonItem showMinimap;
        private DevComponents.DotNetBar.ButtonItem redoButton;
        private DevComponents.DotNetBar.ItemContainer itemContainer9;
        private DevComponents.DotNetBar.ButtonItem fhsEditMode;
        private DevComponents.DotNetBar.ButtonItem ropeEditMode;
        private DevComponents.DotNetBar.ButtonItem chairsEditMode;
        private DevComponents.DotNetBar.ButtonItem tooltipsEditMode;
        private DevComponents.DotNetBar.QatCustomizeItem qatCustomizeItem1;
        private System.Windows.Forms.ToolStrip statusStrip;
        private System.Windows.Forms.ToolStripLabel cordsLabel;
        private DevComponents.DotNetBar.CheckBoxItem viewBackgrounds;
        private DevComponents.DotNetBar.ButtonItem emulateParallax;
        private DevComponents.DotNetBar.StyleManager styleManager;
        private DevComponents.DotNetBar.DotNetBarManager dotNetBarManager;
        private DevComponents.DotNetBar.DockSite dockSite4;
        private DevComponents.DotNetBar.DockSite dockSite1;
        private DevComponents.DotNetBar.DockSite dockSite2;
        private DevComponents.DotNetBar.DockSite dockSite3;
        private DevComponents.DotNetBar.DockSite dockSite5;
        private DevComponents.DotNetBar.DockSite dockSite6;
        private DevComponents.DotNetBar.DockSite dockSite7;
        private DevComponents.DotNetBar.DockSite dockSite8;
        private DevComponents.DotNetBar.Bar dockBar;
        private DevComponents.DotNetBar.PanelDockContainer panelDockContainer1;
        private DevComponents.DotNetBar.DockContainerItem tileDockBox;
        private DevComponents.DotNetBar.PanelDockContainer panelDockContainer3;
        private DevComponents.DotNetBar.PanelDockContainer panelDockContainer2;
        private DevComponents.DotNetBar.DockContainerItem objsDockBox;
        private DevComponents.DotNetBar.DockContainerItem lifeDockBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private KoolkLVContainer tileImagesContainer;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button tileBrowse;
        private System.Windows.Forms.ListBox tileSetList;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.ComboBoxItem layersComboBox;
        private DevComponents.DotNetBar.CheckBoxItem allLayersBox;
        private DevComponents.DotNetBar.ItemContainer itemContainer8;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.Editors.ComboItem comboItem5;
        private DevComponents.Editors.ComboItem comboItem6;
        private DevComponents.Editors.ComboItem comboItem7;
        private DevComponents.Editors.ComboItem comboItem8;
        private DevComponents.DotNetBar.ButtonItem randomTiles;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.ListBox objSetListBox;
        private System.Windows.Forms.ListBox objL0ListBox;
        private KoolkLVContainer objImagesContainer;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.ListBox objL1ListBox;
        private DevComponents.DotNetBar.PanelDockContainer panelDockContainer4;
        private DevComponents.DotNetBar.DockContainerItem bgDockBox;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private System.Windows.Forms.ListBox bgSetListBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX bgBack;
        private DevComponents.DotNetBar.Controls.CheckBoxX aniBg;
        private KoolkLVContainer bgImageContainer;
        private DevComponents.DotNetBar.PanelDockContainer panelDockContainer6;
        private DevComponents.DotNetBar.DockContainerItem dockContainerItem1;
        private DevComponents.DotNetBar.DockContainerItem dockContainerItem2;
        private System.Windows.Forms.SplitContainer splitContainer8;
        private DevComponents.DotNetBar.Controls.CheckBoxX npcRButton;
        private DevComponents.DotNetBar.Controls.CheckBoxX mobRButton;
        private DevComponents.DotNetBar.Controls.CheckBoxX reactorRButton;
        private System.Windows.Forms.PictureBox lifePictureBox;
        private System.Windows.Forms.SplitContainer splitContainer9;
        private System.Windows.Forms.ListBox lifeListBox;
        private DevComponents.DotNetBar.Controls.TextBoxX lifeSearchBox;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonItem mapSimulatorButton;
        private KoolkLVContainer miscItemsContainer;
        private DevComponents.DotNetBar.ItemContainer itemContainer10;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.PanelDockContainer panelDockContainer5;
        private KoolkLVContainer portalImageContainer;
        private DevComponents.DotNetBar.DockContainerItem portalDockBox;
        private DevComponents.DotNetBar.DockContainerItem objDockBox;
        private System.Windows.Forms.ToolStripLabel itemDescLabel;
        private DevComponents.DotNetBar.ButtonItem regenMinimap;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.ButtonItem btnHaRepacker;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.PanelDockContainer panelDockContainer7;
        private DevComponents.DotNetBar.DockContainerItem dockContainerItem3;
        private DevComponents.DotNetBar.Bar bar2;
        private DevComponents.DotNetBar.PanelDockContainer panelDockContainer8;
        private DevComponents.DotNetBar.DockContainerItem dockContainerItem4;
    }
}

