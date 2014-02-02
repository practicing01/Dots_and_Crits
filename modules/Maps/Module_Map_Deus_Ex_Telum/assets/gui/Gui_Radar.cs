function Module_Map_Deus_Ex_Telum::Gui_Radar_Spawn(%this)
{

%GuiSpriteCtrl=new GuiSpriteCtrl()
{

HorizSizing="relative";
VertSizing="relative";
Extent="64 64";
Position=Scale_Vector_To_Resolution_By_Resolution("211 326","800 480",$Resolution);
Profile="GuiDefaultProfile";
isContainer="1";
canSaveDynamicFields="1";

Image="Module_Map_Deus_Ex_Telum:Image_Radar";

Bool_Delete_Me="1";

};

Gui_Dots_and_Crits_Overlay.addGuiControl(%GuiSpriteCtrl);

%this.Gui_Radar=%GuiSpriteCtrl;

%this.Radar_Rotate();

}
