function Dots_and_Crits::Gui_Pause_Menu_Populate_Cards_List(%this)
{

/*Search for cards.*/

Gui_List_Pause_Menu_Cards.clearItems();

%Card_Modules=ModuleDatabase.findModuleTypes("Card",false);

if (!isObject(%this.Simset_ModuleID_Cards))
{

%this.Simset_ModuleID_Cards=new SimSet();

}

%this.Simset_ModuleID_Cards.clear();

%Card_Count=getWordCount(%Card_Modules);

for (%x=0;%x<%Card_Count;%x++)
{

%Module_ID_Card=getWord(%Card_Modules,%x);

ModuleDatabase.LoadExplicit(%Module_ID_Card.ModuleId);

%Script_Object_Card=new ScriptObject()
{
Module_ID_Card=%Module_ID_Card.ModuleId;
String_Description=%Module_ID_Card.Description;
};

%this.Simset_ModuleID_Cards.add(%Script_Object_Card);

Gui_List_Pause_Menu_Cards.addItem(%Module_ID_Card.Description);

}

}
