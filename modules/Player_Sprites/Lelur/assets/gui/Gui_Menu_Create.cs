function Module_Player_Sprite_Lelur::Gui_Menu_Create(%this,%Sprite_Player)
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
      
      class="Module_Player_Sprite_Lelur_Gui_Menu";
      
      String_Action="Move";
      
      Sprite_Player_Parent=%Sprite_Player;
      
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
      
      class="Module_Player_Sprite_Lelur_Gui_Menu";
      
      String_Action="Attack";
      
      Sprite_Player_Parent=%Sprite_Player;
      
   };
   new GuiButtonCtrl() {
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
      text = "Emote";
      groupNum = "-1";
      buttonType = "PushButton";
      useMouseEvents = "1";
      
      Bool_Delete_Me="1";
      
      class="Module_Player_Sprite_Lelur_Gui_Menu";
      
      String_Action="Emote";
      
      Sprite_Player_Parent=%Sprite_Player;
      
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
      text = "Config";
      groupNum = "-1";
      buttonType = "PushButton";
      useMouseEvents = "1";
      
      Bool_Delete_Me="1";
      
      class="Module_Player_Sprite_Lelur_Gui_Menu";
      
      String_Action="Config";
      
      Sprite_Player_Parent=%Sprite_Player;
      
   };
};
//--- OBJECT WRITE END ---

return %Gui_Menu;

}
