function Module_Map_Deus_Ex_Telum::Gui_Scroll_Arrows_Spawn(%this)
{

%GuiSpriteCtrl=new GuiSpriteCtrl()
{

class="Class_Module_Map_Deus_Ex_Telum_Gui_Sprite";

HorizSizing="relative";
VertSizing="relative";
Extent="64 64";
Position="672 0";
Profile="GuiDefaultProfile";
isContainer="1";
canSaveDynamicFields="1";

Image="Module_Map_Deus_Ex_Telum:Image_Scroll_Arrow_Up";

Bool_Delete_Me="1";

};

%GuiButtonCtrl=new GuiButtonCtrl()
{

class="Class_Module_Map_Deus_Ex_Telum_Gui_Button_Scroll_Arrow";

HorizSizing="relative";
VertSizing="relative";
Extent="64 64";
Position="0 0";
Profile="GuiTransparentProfile";
isContainer="1";
canSaveDynamicFields="1";

Module_ID_Map=Module_Map_Deus_Ex_Telum;

Arrow_Direction="Up";

Bool_Delete_Me="1";

};

%GuiSpriteCtrl.addGuiControl(%GuiButtonCtrl);

Gui_Dots_and_Crits_Overlay.addGuiControl(%GuiSpriteCtrl);

/**********************************************************/

%GuiSpriteCtrl=new GuiSpriteCtrl()
{

class="Class_Module_Map_Deus_Ex_Telum_Gui_Sprite";

HorizSizing="relative";
VertSizing="relative";
Extent="64 64";
Position="672 128";
Profile="GuiDefaultProfile";
isContainer="1";
canSaveDynamicFields="1";

Image="Module_Map_Deus_Ex_Telum:Image_Scroll_Arrow_Down";

Bool_Delete_Me="1";

};

%GuiButtonCtrl=new GuiButtonCtrl()
{

class="Class_Module_Map_Deus_Ex_Telum_Gui_Button_Scroll_Arrow";

HorizSizing="relative";
VertSizing="relative";
Extent="64 64";
Position="0 0";
Profile="GuiTransparentProfile";
isContainer="1";
canSaveDynamicFields="1";

Module_ID_Map=Module_Map_Deus_Ex_Telum;

Arrow_Direction="Down";

Bool_Delete_Me="1";

};

%GuiSpriteCtrl.addGuiControl(%GuiButtonCtrl);

Gui_Dots_and_Crits_Overlay.addGuiControl(%GuiSpriteCtrl);

/**********************************************************/

%GuiSpriteCtrl=new GuiSpriteCtrl()
{

class="Class_Module_Map_Deus_Ex_Telum_Gui_Sprite";

HorizSizing="relative";
VertSizing="relative";
Extent="64 64";
Position="608 64";
Profile="GuiDefaultProfile";
isContainer="1";
canSaveDynamicFields="1";

Image="Module_Map_Deus_Ex_Telum:Image_Scroll_Arrow_Left";

Bool_Delete_Me="1";

};

%GuiButtonCtrl=new GuiButtonCtrl()
{

class="Class_Module_Map_Deus_Ex_Telum_Gui_Button_Scroll_Arrow";

HorizSizing="relative";
VertSizing="relative";
Extent="64 64";
Position="0 0";
Profile="GuiTransparentProfile";
isContainer="1";
canSaveDynamicFields="1";

Module_ID_Map=Module_Map_Deus_Ex_Telum;

Arrow_Direction="Left";

Bool_Delete_Me="1";

};

%GuiSpriteCtrl.addGuiControl(%GuiButtonCtrl);

Gui_Dots_and_Crits_Overlay.addGuiControl(%GuiSpriteCtrl);

/**********************************************************/

%GuiSpriteCtrl=new GuiSpriteCtrl()
{

class="Class_Module_Map_Deus_Ex_Telum_Gui_Sprite";

HorizSizing="relative";
VertSizing="relative";
Extent="64 64";
Position="736 64";
Profile="GuiDefaultProfile";
isContainer="1";
canSaveDynamicFields="1";

Image="Module_Map_Deus_Ex_Telum:Image_Scroll_Arrow_Right";

Bool_Delete_Me="1";

};

%GuiButtonCtrl=new GuiButtonCtrl()
{

class="Class_Module_Map_Deus_Ex_Telum_Gui_Button_Scroll_Arrow";

HorizSizing="relative";
VertSizing="relative";
Extent="64 64";
Position="0 0";
Profile="GuiTransparentProfile";
isContainer="1";
canSaveDynamicFields="1";

Module_ID_Map=Module_Map_Deus_Ex_Telum;

Arrow_Direction="Right";

Bool_Delete_Me="1";

};

%GuiSpriteCtrl.addGuiControl(%GuiButtonCtrl);

Gui_Dots_and_Crits_Overlay.addGuiControl(%GuiSpriteCtrl);

/**********************************************************/

%GuiSpriteCtrl=new GuiSpriteCtrl()
{

class="Class_Module_Map_Deus_Ex_Telum_Gui_Sprite";

HorizSizing="relative";
VertSizing="relative";
Extent="62 62";
Position="672 65";
Profile="GuiDefaultProfile";
isContainer="1";
canSaveDynamicFields="1";

Image="Module_Map_Deus_Ex_Telum:Image_Button_Mount_Camera";

Bool_Delete_Me="1";

};

%GuiButtonCtrl=new GuiButtonCtrl()
{

class="Class_Module_Map_Deus_Ex_Telum_Gui_Button_Scroll_Arrow";

HorizSizing="relative";
VertSizing="relative";
Extent="62 62";
Position="0 0";
Profile="GuiTransparentProfile";
isContainer="1";
canSaveDynamicFields="1";

Module_ID_Map=Module_Map_Deus_Ex_Telum;

Arrow_Direction="Center";

Bool_Delete_Me="1";

};

%GuiSpriteCtrl.addGuiControl(%GuiButtonCtrl);

Gui_Dots_and_Crits_Overlay.addGuiControl(%GuiSpriteCtrl);

/**********************************************************/

}
