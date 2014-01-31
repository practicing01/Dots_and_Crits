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
Extent = "250 50";
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

}
