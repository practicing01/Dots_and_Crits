function Module_Card_Summon_Unit_Gui_Menu::onAction(%this)
{

if (%this.String_Action$="Move")
{

%this.Sprite_Parent.Bool_Waiting_For_Move=true;

}
else if (%this.String_Action$="Attack")
{

%this.Sprite_Parent.Bool_Waiting_For_Attack=true;

}

}
