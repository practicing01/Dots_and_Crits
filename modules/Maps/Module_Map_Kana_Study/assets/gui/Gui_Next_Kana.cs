function Module_Map_Kana_Study::Gui_Next_Kana_Spawn(%this)
{

%GuiSpriteCtrl=new GuiSpriteCtrl()
{

class="Class_Module_Map_Kana_Study_Gui_Sprite";

HorizSizing="relative";
VertSizing="relative";
Extent="62 62";
Position=Scale_Vector_To_Resolution_By_Resolution("672 190","800 480",$Resolution);
Profile="GuiDefaultProfile";
isContainer="1";
canSaveDynamicFields="1";

Image="Module_Map_Kana_Study:Image_Button_Mount_Camera";

Bool_Delete_Me="1";

};

%GuiButtonCtrl=new GuiButtonCtrl()
{

class="Class_Module_Map_Kana_Study_Gui_Button_Kana";

HorizSizing="relative";
VertSizing="relative";
Extent="62 62";
Position="0 0";
Profile="GuiTransparentProfile";
isContainer="1";
canSaveDynamicFields="1";

Module_ID_Map=%this;

Bool_Delete_Me="1";

};

%GuiSpriteCtrl.addGuiControl(%GuiButtonCtrl);

Gui_Dots_and_Crits_Overlay.addGuiControl(%GuiSpriteCtrl);

}
