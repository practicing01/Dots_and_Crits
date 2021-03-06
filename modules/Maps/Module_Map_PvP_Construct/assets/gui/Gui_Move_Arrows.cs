function Module_Map_PvP_Construct::Gui_Move_Arrows_Spawn(%this)
{

%GuiSpriteCtrl=new GuiSpriteCtrl()
{

class="Class_Module_Map_PvP_Construct_Gui_Sprite";

HorizSizing="relative";
VertSizing="relative";
Extent="64 64";
Position=Scale_Vector_To_Resolution_By_Resolution("64 0","800 480",$Resolution);
//Extent="100 100";
//Position="100 0";
Profile="GuiDefaultProfile";
isContainer="1";
canSaveDynamicFields="1";

Image="Module_Map_PvP_Construct:Image_Scroll_Arrow_Up";

Bool_Delete_Me="1";

};

%GuiButtonCtrl=new GuiButtonCtrl()
{

class="Class_Module_Map_PvP_Construct_Gui_Button_Move_Arrow";

HorizSizing="relative";
VertSizing="relative";
Extent="64 64";
//Extent="100 100";
Position="0 0";
Profile="GuiTransparentProfile";
isContainer="1";
canSaveDynamicFields="1";

Module_ID_Map=Module_Map_PvP_Construct;

Arrow_Direction="Up";

Bool_Delete_Me="1";

};

%GuiSpriteCtrl.addGuiControl(%GuiButtonCtrl);

Gui_Dots_and_Crits_Overlay.addGuiControl(%GuiSpriteCtrl);

%this.Gui_Button_Move_Arrow_Up=%GuiButtonCtrl;

/**********************************************************/

%GuiSpriteCtrl=new GuiSpriteCtrl()
{

class="Class_Module_Map_PvP_Construct_Gui_Sprite";

HorizSizing="relative";
VertSizing="relative";
Extent="64 64";
Position=Scale_Vector_To_Resolution_By_Resolution("64 128","800 480",$Resolution);
//Extent="100 100";
//Position="100 200";
Profile="GuiDefaultProfile";
isContainer="1";
canSaveDynamicFields="1";

Image="Module_Map_PvP_Construct:Image_Scroll_Arrow_Down";

Bool_Delete_Me="1";

};

%GuiButtonCtrl=new GuiButtonCtrl()
{

class="Class_Module_Map_PvP_Construct_Gui_Button_Move_Arrow";

HorizSizing="relative";
VertSizing="relative";
Extent="64 64";
Position="0 0";
//Extent="100 100";
//Position="0 0";
Profile="GuiTransparentProfile";
isContainer="1";
canSaveDynamicFields="1";

Module_ID_Map=Module_Map_PvP_Construct;

Arrow_Direction="Down";

Bool_Delete_Me="1";

};

%GuiSpriteCtrl.addGuiControl(%GuiButtonCtrl);

Gui_Dots_and_Crits_Overlay.addGuiControl(%GuiSpriteCtrl);

%this.Gui_Button_Move_Arrow_Down=%GuiButtonCtrl;

/**********************************************************/

%GuiSpriteCtrl=new GuiSpriteCtrl()
{

class="Class_Module_Map_PvP_Construct_Gui_Sprite";

HorizSizing="relative";
VertSizing="relative";
Extent="64 64";
Position=Scale_Vector_To_Resolution_By_Resolution("0 64","800 480",$Resolution);
//Extent="100 100";
//Position="0 100";
Profile="GuiDefaultProfile";
isContainer="1";
canSaveDynamicFields="1";

Image="Module_Map_PvP_Construct:Image_Scroll_Arrow_Left";

Bool_Delete_Me="1";

};

%GuiButtonCtrl=new GuiButtonCtrl()
{

class="Class_Module_Map_PvP_Construct_Gui_Button_Move_Arrow";

HorizSizing="relative";
VertSizing="relative";
Extent="64 64";
Position="0 0";
//Extent="100 100";
//Position="0 0";
Profile="GuiTransparentProfile";
isContainer="1";
canSaveDynamicFields="1";

Module_ID_Map=Module_Map_PvP_Construct;

Arrow_Direction="Left";

Bool_Delete_Me="1";

};

%GuiSpriteCtrl.addGuiControl(%GuiButtonCtrl);

Gui_Dots_and_Crits_Overlay.addGuiControl(%GuiSpriteCtrl);

%this.Gui_Button_Move_Arrow_Left=%GuiButtonCtrl;

/**********************************************************/

%GuiSpriteCtrl=new GuiSpriteCtrl()
{

class="Class_Module_Map_PvP_Construct_Gui_Sprite";

HorizSizing="relative";
VertSizing="relative";
Extent="64 64";
Position=Scale_Vector_To_Resolution_By_Resolution("128 64","800 480",$Resolution);
//Extent="100 100";
//Position="200 100";
Profile="GuiDefaultProfile";
isContainer="1";
canSaveDynamicFields="1";

Image="Module_Map_PvP_Construct:Image_Scroll_Arrow_Right";

Bool_Delete_Me="1";

};

%GuiButtonCtrl=new GuiButtonCtrl()
{

class="Class_Module_Map_PvP_Construct_Gui_Button_Move_Arrow";

HorizSizing="relative";
VertSizing="relative";
Extent="64 64";
Position="0 0";
//Extent="100 100";
//Position="0 0";
Profile="GuiTransparentProfile";
isContainer="1";
canSaveDynamicFields="1";

Module_ID_Map=Module_Map_PvP_Construct;

Arrow_Direction="Right";

Bool_Delete_Me="1";

};

%GuiSpriteCtrl.addGuiControl(%GuiButtonCtrl);

Gui_Dots_and_Crits_Overlay.addGuiControl(%GuiSpriteCtrl);

%this.Gui_Button_Move_Arrow_Right=%GuiButtonCtrl;

/**********************************************************/
/*
%GuiSpriteCtrl=new GuiSpriteCtrl()
{

class="Class_Module_Map_PvP_Construct_Gui_Sprite";

HorizSizing="relative";
VertSizing="relative";
Extent="62 62";
Position=Scale_Vector_To_Resolution_By_Resolution("65 65","800 480",$Resolution);
Profile="GuiDefaultProfile";
isContainer="1";
canSaveDynamicFields="1";

Image="Module_Map_PvP_Construct:Image_Button_Mount_Camera";

Bool_Delete_Me="1";

};

%GuiButtonCtrl=new GuiButtonCtrl()
{

class="Class_Module_Map_PvP_Construct_Gui_Button_Move_Arrow";

HorizSizing="relative";
VertSizing="relative";
Extent="62 62";
Position="0 0";
Profile="GuiTransparentProfile";
isContainer="1";
canSaveDynamicFields="1";

Module_ID_Map=Module_Map_PvP_Construct;

Arrow_Direction="Center";

Bool_Delete_Me="1";

};

%GuiSpriteCtrl.addGuiControl(%GuiButtonCtrl);

Gui_Dots_and_Crits_Overlay.addGuiControl(%GuiSpriteCtrl);

%this.Gui_Button_Move_Arrow_Center=%GuiButtonCtrl;
*/
/**********************************************************/

%GuiSpriteCtrl=new GuiSpriteCtrl()
{

class="Class_Module_Map_PvP_Construct_Gui_Sprite";

HorizSizing="relative";
VertSizing="relative";
Extent="64 64";
Position=Scale_Vector_To_Resolution_By_Resolution("128 128","800 480",$Resolution);
//Extent="64 64";
//Position="200 200";
Profile="GuiDefaultProfile";
isContainer="1";
canSaveDynamicFields="1";

Image="Module_Map_PvP_Construct:Image_Scroll_Arrow_Toggle_Menu";

Bool_Delete_Me="1";

};

%GuiButtonCtrl=new GuiButtonCtrl()
{

class="Class_Module_Map_PvP_Construct_Gui_Button_Move_Arrow";

HorizSizing="relative";
VertSizing="relative";
Extent="64 64";
Position="0 0";
Profile="GuiTransparentProfile";
isContainer="1";
canSaveDynamicFields="1";

Module_ID_Map=Module_Map_PvP_Construct;

Arrow_Direction="Toggle_Menu";

Bool_Delete_Me="1";

};

%GuiSpriteCtrl.addGuiControl(%GuiButtonCtrl);

Gui_Dots_and_Crits_Overlay.addGuiControl(%GuiSpriteCtrl);

%this.Gui_Button_Move_Arrow_Toggle_Menu=%GuiButtonCtrl;

/**********************************************************/

}
