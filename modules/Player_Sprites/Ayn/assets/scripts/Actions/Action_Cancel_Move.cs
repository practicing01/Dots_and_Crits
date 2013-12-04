function Module_Player_Sprite_Ayn::Action_Cancel_Move(%this,%Player_Information)
{

%Player_Information.Composite_Sprite.cancelMoveTo();

%this.onMoveToComplete(%Player_Information.Composite_Sprite);

}
