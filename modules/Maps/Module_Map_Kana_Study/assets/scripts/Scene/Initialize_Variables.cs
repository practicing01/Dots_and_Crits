function Module_Map_Kana_Study::Initialize_Variables(%this)
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

%this.Script_Object_Input_Controller=new ScriptObject()
{

class="Class_Kana_Study_Input_Controller";

};

Window_Dots_and_Crits.addInputListener(%this.Script_Object_Input_Controller);

/***********************************************************************/

%this.ScriptObject_Kana_Fields=0;

%this.Object_Count=0;

%this.Simset_Objects=new SimSet();

/***********************************************************************/

}
