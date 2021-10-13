using ShitStain.Other;
using ShitStain.Utils;

namespace ShitStain.Modules {
	class Autoclicker : Module {
		public Autoclicker() : base("Autoclicker", "Combat", "Click really fast (once every frame)") {

		}

		public override void onUpdate() {
			Mouse.MouseEvent(Mouse.MouseFlags.LeftUp | Mouse.MouseFlags.LeftDown);
		}
	}
}
