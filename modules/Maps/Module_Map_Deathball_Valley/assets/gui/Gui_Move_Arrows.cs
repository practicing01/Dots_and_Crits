function Module_Map_Deathball_Valley::Gui_Move_Arrows_Spawn(%this)
{

%GuiSpriteCtrl=new GuiSpriteCtrl()
{

class="Class_Module_Map_Deathball_Valley_Gui_Sprite";

HorizSizing="relative";
VertSizing="relative";
Extent="64 64";
Position="64 0";
Profile="GuiDefaultProfile";
isContainer="1";
canSaveDynamicFields="1";

Image="Module_Map_Deathball_Valley:Image_Scroll_Arrow_Up";

Bool_Delete_Me="1";

};

%GuiButtonCtrl=new GuiButtonCtrl()
{

class="Class_Module_Map_Deathball_Valley_Gui_Button_Move_Arrow";

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

Window_Dots_and_Crits.addGuiControl(%GuiSpriteCtrl);

%this.Gui_Button_Move_Arrow_Up=%GuiButtonCtrl;

/**********************************************************/

%GuiSpriteCtrl=new GuiSpriteCtrl()
{

class="Class_Module_Map_Deathball_Valley_Gui_Sprite";

HorizSizing="relative";
VertSizing="relative";
Extent="64 64";
Position="64 128";
Profile="GuiDefaultProfile";
isContainer="1";
canSaveDynamicFields="1";

Image="Module_Map_Deathball_Valley:Image_Scroll_Arrow_Down";

Bool_Delete_Me="1";

};

%GuiButtonCtrl=new GuiButtonCtrl()
{

class="Class_Module_Map_Deathball_Valley_Gui_Button_Move_Arrow";

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

Window_Dots_and_Crits.addGuiControl(%GuiSpriteCtrl);

%this.Gui_Button_Move_Arrow_Down=%GuiButtonCtrl;

/**********************************************************/

%GuiSpriteCtrl=new GuiSpriteCtrl()
{

class="Class_Module_Map_Deathball_Valley_Gui_Sprite";

HorizSizing="relative";
VertSizing="relative";
Extent="64 64";
Position="0 64";
Profile="GuiDefaultProfile";
isContainer="1";
canSaveDynamicFields="1";

Image="Module_Map_Deathball_Valley:Image_Scroll_Arrow_Left";

Bool_Delete_Me="1";

};

%GuiButtonCtrl=new GuiButtonCtrl()
{

class="Class_Module_Map_Deathball_Valley_Gui_Button_Move_Arrow";

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

Window_Dots_and_Crits.addGuiControl(%GuiSpriteCtrl);

%this.Gui_Button_Move_Arrow_Left=%GuiButtonCtrl;

/**********************************************************/

%GuiSpriteCtrl=new GuiSpriteCtrl()
{

class="Class_Module_Map_Deathball_Valley_Gui_Sprite";

HorizSizing="relative";
VertSizing="relative";
Extent="64 64";
Position="128 64";
Profile="GuiDefaultProfile";
isContainer="1";
canSaveDynamicFields="1";

Image="Module_Map_Deathball_Valley:Image_Scroll_Arrow_Right";

Bool_Delete_Me="1";

};

%GuiButtonCtrl=new GuiButtonCtrl()
{

class="Class_Module_Map_Deathball_Valley_Gui_Button_Move_Arrow";

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

Window_Dots_and_Crits.addGuiControl(%GuiSpriteCtrl);

%this.Gui_Button_Move_Arrow_Right=%GuiButtonCtrl;

/**********************************************************/

%GuiSpriteCtrl=new GuiSpriteCtrl()
{

class="Class_Module_Map_Deathball_Valley_Gui_Sprite";

HorizSizing="relative";
VertSizing="relative";
Extent="62 62";
Position="65 65";
Profile="GuiDefaultProfile";
isContainer="1";
canSaveDynamicFields="1";

Image="Module_Map_Deathball_Valley:Image_Button_Mount_Camera";

Bool_Delete_Me="1";

};

%GuiButtonCtrl=new GuiButtonCtrl()
{

class="Class_Module_Map_Deathball_Valley_Gui_Button_Move_Arrow";

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

Window_Dots_and_Crits.addGuiControl(%GuiSpriteCtrl);

%this.Gui_Button_Move_Arrow_Center=%GuiButtonCtrl;

/**********************************************************/

%GuiSpriteCtrl=new GuiSpriteCtrl()
{

class="Class_Module_Map_Deathball_Valley_Gui_Sprite";

HorizSizing="relative";
VertSizing="relative";
Extent="64 64";
Position="128 128";
Profile="GuiDefaultProfile";
isContainer="1";
canSaveDynamicFields="1";

Image="Module_Map_Deathball_Valley:Image_Scroll_Arrow_Toggle_Menu";

Bool_Delete_Me="1";

};

%GuiButtonCtrl=new GuiButtonCtrl()
{

class="Class_Module_Map_Deathball_Valley_Gui_Button_Move_Arrow";

HorizSizing="relative";
VertSizing="relative";
Extent="64 64";
Position="0 0";
Profile="GuiTransparentProfile";
isContainer="1";
canSaveDynamicFields="1";

Module_ID_Map=Module_Map_Deathball_Valley;

Arrow_Direction="Toggle_Menu";

Bool_Delete_Me="1";

};

%GuiSpriteCtrl.addGuiControl(%GuiButtonCtrl);

Window_Dots_and_Crits.addGuiControl(%GuiSpriteCtrl);

%this.Gui_Button_Move_Arrow_Toggle_Menu=%GuiButtonCtrl;

/**********************************************************/

}
