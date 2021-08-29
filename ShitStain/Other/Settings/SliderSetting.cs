using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShitStain.Other.Settings
{
    class SliderSetting : ModuleSetting
    {
        public float min;
        public float max;
        public float value;
        public SettingType type;
        public SliderSetting(float min, float max, float initialValue, string name, Module module) : base(name, module)
        {
            this.min = min;
            this.max = max;
            value = initialValue;
            type = SettingType.Slider;
        }


    }
}
