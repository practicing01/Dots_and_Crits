function Module_Card_Bind_Emote::Gui_Generate(%this)
{

%this.Gui_Window_Emote_Bind=new GuiControl()
{
canSaveDynamicFields = "1";
isContainer = "1";
Profile = "GuiDefaultProfile";
HorizSizing = "relative";
VertSizing = "relative";
Position = ($Resolution.X/2)-125 SPC ($Resolution.Y/2)-25;
Extent = "250 200";
MinExtent = "1 1";
canSave = "1";
Visible = "1";
Active = "1";
tooltipWidth = "250";
hovertime = "1000";

class="Class_Gui_Window_Module_Card_Bind_Emote_Bind";

Bool_Delete_Me="1";

Module_ID_Parent=%this;

};

Gui_Dots_and_Crits_Overlay.add(%this.Gui_Window_Emote_Bind);

%this.Gui_Window_Emote_Bind.setActive(false);

%this.Gui_Window_Emote_Bind.setVisible(false);

/*************************************************************************/

%this.Gui_Edit_Text_Asset_Animation=new GuiTextEditCtrl()
{
canSaveDynamicFields = "1";
isContainer = "1";
Profile = "GuiTextEditProfile";
HorizSizing = "relative";
VertSizing = "relative";
Position = "0 0";
Extent = "150 50";
MinExtent = "1 1";
canSave = "1";
Visible = "1";
Active = "1";
tooltipWidth = "250";
hovertime = "1000";

class="Class_Gui_Window_Module_Card_Bind_Emote_Edit_Text_Asset_Animation";

Bool_Delete_Me="1";

Module_ID_Parent=%this;

};

%this.Gui_Window_Emote_Bind.add(%this.Gui_Edit_Text_Asset_Animation);

/*************************************************************************/

%this.Gui_Edit_Text_Key=new GuiTextEditCtrl()
{
canSaveDynamicFields = "1";
isContainer = "1";
Profile = "GuiTextEditProfile";
HorizSizing = "relative";
VertSizing = "relative";
Position = "150 0";
Extent = "50 50";
MinExtent = "1 1";
canSave = "1";
Visible = "1";
Active = "1";
tooltipWidth = "250";
hovertime = "1000";

class="Class_Gui_Window_Module_Card_Bind_Emote_Edit_Text_Key";

Bool_Delete_Me="1";

Module_ID_Parent=%this;

};

%this.Gui_Window_Emote_Bind.add(%this.Gui_Edit_Text_Key);

/*************************************************************************/

%Gui_Button_Key_Capture=new GuiButtonCtrl()
{
canSaveDynamicFields = "1";
isContainer = "1";
Profile = "BlueButtonProfile";
HorizSizing = "relative";
VertSizing = "relative";
Position = "200 0";
Extent = "50 50";
MinExtent = "1 1";
canSave = "1";
Visible = "1";
Active = "1";
tooltipWidth = "250";
hovertime = "1000";

text="Set Key";

class="Class_Gui_Window_Module_Card_Bind_Emote_Key_Capture";

Bool_Delete_Me="1";

Module_ID_Parent=%this;

};

%this.Gui_Window_Emote_Bind.add(%Gui_Button_Key_Capture);

/*************************************************************************/

%this.Gui_Edit_Text_Filename_Save=new GuiTextEditCtrl()
{
canSaveDynamicFields = "1";
isContainer = "1";
Profile = "GuiTextEditProfile";
HorizSizing = "relative";
VertSizing = "relative";
Position = "0 50";
Extent = "150 50";
MinExtent = "1 1";
canSave = "1";
Visible = "1";
Active = "1";
tooltipWidth = "250";
hovertime = "1000";

class="Class_Gui_Window_Module_Card_Bind_Emote_Edit_Text_Filename_Save";

Bool_Delete_Me="1";

Module_ID_Parent=%this;

};

%this.Gui_Window_Emote_Bind.add(%this.Gui_Edit_Text_Filename_Save);

/*************************************************************************/

%Gui_Button_File_Save=new GuiButtonCtrl()
{
canSaveDynamicFields = "1";
isContainer = "1";
Profile = "BlueButtonProfile";
HorizSizing = "relative";
VertSizing = "relative";
Position = "150 50";
Extent = "100 50";
MinExtent = "1 1";
canSave = "1";
Visible = "1";
Active = "1";
tooltipWidth = "250";
hovertime = "1000";

text="Save Binds";

class="Class_Gui_Window_Module_Card_Bind_Emote_Save_Binds";

Bool_Delete_Me="1";

Module_ID_Parent=%this;

};

%this.Gui_Window_Emote_Bind.add(%Gui_Button_File_Save);

/*************************************************************************/

%Gui_Scroller_Binds=new GuiScrollCtrl()
{
canSaveDynamicFields = "1";
isContainer = "1";
Profile = "GuiLightScrollProfile";
HorizSizing = "relative";
VertSizing = "relative";
Position = "0 100";
Extent = "200 100";
MinExtent = "1 1";
canSave = "1";
Visible = "1";
Active = "1";
tooltipWidth = "250";
hovertime = "1000";
hScrollBar="dynamic";
vScrollBar="dynamic";

Bool_Delete_Me="1";

Module_ID_Parent=%this;

};

%this.Gui_Window_Emote_Bind.add(%Gui_Scroller_Binds);

/*************************************************************************/

%this.Gui_List_Binds=new GuiListBoxCtrl()
{
canSaveDynamicFields = "1";
isContainer = "1";
Profile = "gui_list_profile_colored";
HorizSizing = "relative";
VertSizing = "relative";
Position = "0 100";
Extent = "200 100";
MinExtent = "1 1";
canSave = "1";
Visible = "1";
Active = "1";
tooltipWidth = "250";
hovertime = "1000";
AllowMultipleSelections="0";

class="Class_Gui_Window_Module_Card_Bind_Emote_List_Binds";

Bool_Delete_Me="1";

Module_ID_Parent=%this;

};

%this.Gui_Window_Emote_Bind.add(%this.Gui_List_Binds);

/*Search for bind files.*/

%this.Gui_List_Binds.clearItems();

%String_Bind_Files=getFileList("./../../../../../Binds");

%Bind_Files_Count=getWordCount(%String_Bind_Files);

for (%x=0;%x<%Bind_Files_Count;%x++)
{

%File_Name_Bind=getWord(%String_Bind_Files,%x);

%this.Gui_List_Binds.addItem(%File_Name_Bind);

}

/*************************************************************************/

%Gui_Button_File_Load=new GuiButtonCtrl()
{
canSaveDynamicFields = "1";
isContainer = "1";
Profile = "BlueButtonProfile";
HorizSizing = "relative";
VertSizing = "relative";
Position = "200 100";
Extent = "50 50";
MinExtent = "1 1";
canSave = "1";
Visible = "1";
Active = "1";
tooltipWidth = "250";
hovertime = "1000";

text="Set Binds";

class="Class_Gui_Window_Module_Card_Bind_Emote_Load_Binds";

Bool_Delete_Me="1";

Module_ID_Parent=%this;

};

%this.Gui_Window_Emote_Bind.add(%Gui_Button_File_Load);

}
