function Module_Map_Deus_Ex_Telum::Gui_Radar_Spawn(%this)
{

%GuiSpriteCtrl=new GuiSpriteCtrl()
{

HorizSizing="relative";
VertSizing="relative";
Extent="64 64";
Position="211 326";
Profile="GuiDefaultProfile";
isContainer="1";
canSaveDynamicFields="1";

Image="Module_Map_Deus_Ex_Telum:Image_Radar";

Bool_Delete_Me="1";

};

Window_Dots_and_Crits.addGuiControl(%GuiSpriteCtrl);

%this.Gui_Radar=%GuiSpriteCtrl;

%this.Radar_Rotate();

}
