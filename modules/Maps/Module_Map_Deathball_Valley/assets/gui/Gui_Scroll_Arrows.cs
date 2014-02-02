function Module_Map_Deathball_Valley::Gui_Scroll_Arrows_Spawn(%this)
{

%GuiSpriteCtrl=new GuiSpriteCtrl()
{

class="Class_Module_Map_Deathball_Valley_Gui_Sprite";

HorizSizing="relative";
VertSizing="relative";
Extent="64 64";
Position=Scale_Vector_To_Resolution_By_Resolution("672 0","800 480",$Resolution);
Profile="GuiDefaultProfile";
isContainer="1";
canSaveDynamicFields="1";

Image="Module_Map_Deathball_Valley:Image_Scroll_Arrow_Up";

Bool_Delete_Me="1";

};

%GuiButtonCtrl=new GuiButtonCtrl()
{

class="Class_Module_Map_Deathball_Valley_Gui_Button_Scroll_Arrow";

HorizSizing="relative";
VertSizing="relative";
Extent="64 64";
Position="0 0";
Profile="GuiTransparentProfile";
isContainer="1";
canSaveDynamicFields="1";

Module_ID_Map=Module_Map_Deathball_Valley;

Arrow_Direction="Up";

Bool_Delete_Me="1";

};

%GuiSpriteCtrl.addGuiControl(%GuiButtonCtrl);

Gui_Dots_and_Crits_Overlay.addGuiControl(%GuiSpriteCtrl);

/**********************************************************/

%GuiSpriteCtrl=new GuiSpriteCtrl()
{

class="Class_Module_Map_Deathball_Valley_Gui_Sprite";

HorizSizing="relative";
VertSizing="relative";
Extent="64 64";
Position=Scale_Vector_To_Resolution_By_Resolution("672 128","800 480",$Resolution);
Profile="GuiDefaultProfile";
isContainer="1";
canSaveDynamicFields="1";

Image="Module_Map_Deathball_Valley:Image_Scroll_Arrow_Down";

Bool_Delete_Me="1";

};

%GuiButtonCtrl=new GuiButtonCtrl()
{

class="Class_Module_Map_Deathball_Valley_Gui_Button_Scroll_Arrow";

HorizSizing="relative";
VertSizing="relative";
Extent="64 64";
Position="0 0";
Profile="GuiTransparentProfile";
isContainer="1";
canSaveDynamicFields="1";

Module_ID_Map=Module_Map_Deathball_Valley;

Arrow_Direction="Down";

Bool_Delete_Me="1";

};

%GuiSpriteCtrl.addGuiControl(%GuiButtonCtrl);

Gui_Dots_and_Crits_Overlay.addGuiControl(%GuiSpriteCtrl);

/**********************************************************/

%GuiSpriteCtrl=new GuiSpriteCtrl()
{

class="Class_Module_Map_Deathball_Valley_Gui_Sprite";

HorizSizing="relative";
VertSizing="relative";
Extent="64 64";
Position=Scale_Vector_To_Resolution_By_Resolution("608 64","800 480",$Resolution);
Profile="GuiDefaultProfile";
isContainer="1";
canSaveDynamicFields="1";

Image="Module_Map_Deathball_Valley:Image_Scroll_Arrow_Left";

Bool_Delete_Me="1";

};

%GuiButtonCtrl=new GuiButtonCtrl()
{

class="Class_Module_Map_Deathball_Valley_Gui_Button_Scroll_Arrow";

HorizSizing="relative";
VertSizing="relative";
Extent="64 64";
Position="0 0";
Profile="GuiTransparentProfile";
isContainer="1";
canSaveDynamicFields="1";

Module_ID_Map=Module_Map_Deathball_Valley;

Arrow_Direction="Left";

Bool_Delete_Me="1";

};

%GuiSpriteCtrl.addGuiControl(%GuiButtonCtrl);

Gui_Dots_and_Crits_Overlay.addGuiControl(%GuiSpriteCtrl);

/**********************************************************/

%GuiSpriteCtrl=new GuiSpriteCtrl()
{

class="Class_Module_Map_Deathball_Valley_Gui_Sprite";

HorizSizing="relative";
VertSizing="relative";
Extent="64 64";
Position=Scale_Vector_To_Resolution_By_Resolution("736 64","800 480",$Resolution);
Profile="GuiDefaultProfile";
isContainer="1";
canSaveDynamicFields="1";

Image="Module_Map_Deathball_Valley:Image_Scroll_Arrow_Right";

Bool_Delete_Me="1";

};

%GuiButtonCtrl=new GuiButtonCtrl()
{

class="Class_Module_Map_Deathball_Valley_Gui_Button_Scroll_Arrow";

HorizSizing="relative";
VertSizing="relative";
Extent="64 64";
Position="0 0";
Profile="GuiTransparentProfile";
isContainer="1";
canSaveDynamicFields="1";

Module_ID_Map=Module_Map_Deathball_Valley;

Arrow_Direction="Right";

Bool_Delete_Me="1";

};

%GuiSpriteCtrl.addGuiControl(%GuiButtonCtrl);

Gui_Dots_and_Crits_Overlay.addGuiControl(%GuiSpriteCtrl);

/**********************************************************/

%GuiSpriteCtrl=new GuiSpriteCtrl()
{

class="Class_Module_Map_Deathball_Valley_Gui_Sprite";

HorizSizing="relative";
VertSizing="relative";
Extent="62 62";
Position=Scale_Vector_To_Resolution_By_Resolution("672 65","800 480",$Resolution);
Profile="GuiDefaultProfile";
isContainer="1";
canSaveDynamicFields="1";

Image="Module_Map_Deathball_Valley:Image_Button_Mount_Camera";

Bool_Delete_Me="1";

};

%GuiButtonCtrl=new GuiButtonCtrl()
{

class="Class_Module_Map_Deathball_Valley_Gui_Button_Scroll_Arrow";

HorizSizing="relative";
VertSizing="relative";
Extent="62 62";
Position="0 0";
Profile="GuiTransparentProfile";
isContainer="1";
canSaveDynamicFields="1";

Module_ID_Map=Module_Map_Deathball_Valley;

Arrow_Direction="Center";

Bool_Delete_Me="1";

};

%GuiSpriteCtrl.addGuiControl(%GuiButtonCtrl);

Gui_Dots_and_Crits_Overlay.addGuiControl(%GuiSpriteCtrl);

/**********************************************************/

}
