function Module_Map_PvP_Construct::Keyboard_Bind(%this)
{

GlobalActionMap.bindCmd(keyboard,"w",
"Class_Module_Map_PvP_Construct_Gui_Button_Move_Arrow::onAction(Module_Map_PvP_Construct.Gui_Button_Move_Arrow_Up);","");

GlobalActionMap.bindCmd(keyboard,"s",
"Class_Module_Map_PvP_Construct_Gui_Button_Move_Arrow::onAction(Module_Map_PvP_Construct.Gui_Button_Move_Arrow_Down);","");

GlobalActionMap.bindCmd(keyboard,"a",
"Class_Module_Map_PvP_Construct_Gui_Button_Move_Arrow::onAction(Module_Map_PvP_Construct.Gui_Button_Move_Arrow_Left);","");

GlobalActionMap.bindCmd(keyboard,"d",
"Class_Module_Map_PvP_Construct_Gui_Button_Move_Arrow::onAction(Module_Map_PvP_Construct.Gui_Button_Move_Arrow_Right);","");

}