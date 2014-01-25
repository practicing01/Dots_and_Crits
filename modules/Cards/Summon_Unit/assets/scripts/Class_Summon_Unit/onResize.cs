function Class_Summon_Unit::onResize(%this)
{

%this.clearCollisionShapes();

%this.createPolygonBoxCollisionShape(%this.Size);

}
