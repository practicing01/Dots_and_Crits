function Class_Module_Map_Kana_Study_Gui_Button_Kana::onAction(%this)
{

//Next phrase.

schedule(0,0,"Module_Map_Kana_Study::Load_Dictionary",%this.Module_ID_Map);

schedule(1,0,"Module_Map_Kana_Study::Kana_Fields_Generate",%this.Module_ID_Map);

}
