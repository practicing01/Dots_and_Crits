function Module_Map_Bath_Salts::Initialize_Variables(%this)
{

%this.Simset_Portal_Spawn=new SimSet();

%this.Camera_Move_Schedule=new ScriptObject()
{

Schedule_Handle=0;

Direction="0";

};

%this.Player_Move_Schedule=new ScriptObject()
{

Schedule_Handle=0;

Direction="0";

};

%this.Gui_Button_Move_Arrow_Up=0;
%this.Gui_Button_Move_Arrow_Down=0;
%this.Gui_Button_Move_Arrow_Left=0;
%this.Gui_Button_Move_Arrow_Right=0;
%this.Gui_Button_Move_Arrow_Center=0;
%this.Gui_Button_Move_Arrow_Toggle_Menu=0;

%this.Object_Count=0;

%this.Simset_Objects=new SimSet();

%this.Score=0;

%this.Gui_Text_Score=new GuiTextCtrl()
{
Position="211 326";
HorizSizing="relative";
VertSizing="relative";
Text="0"; 
Extent="64 64";
isContainer="1";
Profile="Gui_Profile_Modalless_Text";
hovertime="1000";
MaxLength="128";

Bool_Delete_Me="1";

};

Gui_Dots_and_Crits_Overlay.addGuiControl(%this.Gui_Text_Score);

%this.Script_Object_Input_Controller=new ScriptObject()
{

class="Class_Bath_Salts_Input_Controller";

};

Window_Dots_and_Crits.addInputListener(%this.Script_Object_Input_Controller);

}
