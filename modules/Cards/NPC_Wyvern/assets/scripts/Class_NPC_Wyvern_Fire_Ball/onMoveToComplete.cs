function Class_NPC_Wyvern_Fire_Ball::onMoveToComplete(%this)
{

%this.Module_ID_Parent.NPC_Wyvern_Explosion_Spawn(%this.Position);

%this.Module_ID_Parent.Simset_Objects.remove(%this);

%this.safeDelete();

}
