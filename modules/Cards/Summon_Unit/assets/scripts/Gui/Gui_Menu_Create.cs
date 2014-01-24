function Module_Card_Summon_Unit::Gui_Menu_Create(%this,%Sprite)
{

//--- OBJECT WRITE BEGIN ---
%Gui_Menu=new GuiControl() {
   canSaveDynamicFields = "1";
   isContainer = "1";
   Profile = "gui_profile_modalless";
   HorizSizing = "relative";
   VertSizing = "relative";
   Position = "0 0";
   Extent = "800 480";
   MinExtent = "1 1";
   canSave = "1";
   Visible = "1";
   Active = "0";
   tooltipWidth = "250";
   hovertime = "1000";
   
   Bool_Delete_Me="1";

   new GuiButtonCtrl() {
      canSaveDynamicFields = "1";
      isContainer = "0";
      Profile = "BlueButtonProfile";
      HorizSizing = "relative";
      VertSizing = "relative";
      Position = "350 215";
      Extent = "50 25";
      MinExtent = "1 1";
      canSave = "1";
      Visible = "1";
      Active = "1";
      tooltipWidth = "250";
      hovertime = "1000";
      text = "Move";
      groupNum = "-1";
      buttonType = "PushButton";
      useMouseEvents = "1";
      
      Bool_Delete_Me="1";
      
      class="Module_Card_Summon_Unit_Gui_Menu";
      
      String_Action="Move";
      
      Sprite_Parent=%Sprite;
      
   };
   new GuiButtonCtrl() {
      canSaveDynamicFields = "1";
      isContainer = "0";
      Profile = "BlueButtonProfile";
      HorizSizing = "relative";
      VertSizing = "relative";
      Position = "400 215";
      Extent = "50 25";
      MinExtent = "1 1";
      canSave = "1";
      Visible = "1";
      Active = "1";
      tooltipWidth = "250";
      hovertime = "1000";
      text = "Attack";
      groupNum = "-1";
      buttonType = "PushButton";
      useMouseEvents = "1";
      
      Bool_Delete_Me="1";
      
      class="Module_Card_Summon_Unit_Gui_Menu";
      
      String_Action="Attack";
      
      Sprite_Parent=%Sprite;
      
   };
/*   new GuiButtonCtrl() {
      canSaveDynamicFields = "1";
      isContainer = "0";
      Profile = "BlueButtonProfile";
      HorizSizing = "relative";
      VertSizing = "relative";
      Position = "400 240";
      Extent = "50 25";
      MinExtent = "1 1";
      canSave = "1";
      Visible = "1";
      Active = "1";
      tooltipWidth = "250";
      hovertime = "1000";
      text = "Skill";
      groupNum = "-1";
      buttonType = "PushButton";
      useMouseEvents = "1";
      
      Bool_Delete_Me="1";
      
      class="Module_Card_Summon_Unit_Gui_Menu";
      
      String_Action="Skill";
      
      Sprite_Parent=%Sprite;
      
   };
   new GuiButtonCtrl() {
      canSaveDynamicFields = "1";
      isContainer = "0";
      Profile = "BlueButtonProfile";
      HorizSizing = "relative";
      VertSizing = "relative";
      Position = "350 240";
      Extent = "50 25";
      MinExtent = "1 1";
      canSave = "1";
      Visible = "1";
      Active = "1";
      tooltipWidth = "250";
      hovertime = "1000";
      text = "Set Skill";
      groupNum = "-1";
      buttonType = "PushButton";
      useMouseEvents = "1";
      
      Bool_Delete_Me="1";
      
      class="Module_Card_Summon_Unit_Gui_Menu";
      
      String_Action="Set Skill";
      
      Sprite_Parent=%Sprite;
      
   };*/
};
//--- OBJECT WRITE END ---

return %Gui_Menu;

}
