function Gui_Pause_Menu::Gui_Button_Pause_Menu_Cast_Card(%this)
{

if (!isObject($Simset_Loaded_Card_Modules)){echo("Simset_Loaded_Card_Modules doesn't exist.");return;}

%Module_ID_Card=-1;

if (Gui_List_Pause_Menu_Cards.getSelectedItem()!=-1)
{

%Module_ID_Card=Dots_and_Crits.Simset_ModuleID_Cards.getObject
(Gui_List_Pause_Menu_Cards.getSelectedItem()).Module_ID_Card;

}

if (%Module_ID_Card==-1){return;}

for (%x=0;%x<$Simset_Loaded_Card_Modules.getCount();%x++)
{

%Card=$Simset_Loaded_Card_Modules.getObject(%x);

if (%Card.Module_ID_Card$=%Module_ID_Card)
{

//Card already loaded, cast it.

%Module_ID_Card.onAction();

return;

}

}

//Card not loaded, relay to load.

commandToServer('Register_Card_To_Load',%Module_ID_Card);

}
