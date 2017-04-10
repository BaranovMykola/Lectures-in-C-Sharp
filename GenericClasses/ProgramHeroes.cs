using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses
{
    class Hero
    {
        public string Name { get; set; }
        protected List<string> Skills = new List<string>();

        public Hero(string name)
        {
            this.Name = name;
        }

        public void AddSkill(string skill)
        {
            Skills.Add(skill);
        }

        public string GetSkills()
        {
            return string.Join(", ", Skills.ToArray());
        }
    }

    class MagicHero : Hero
    {
        public MagicHero(string Name, int MightPower): base(Name)
        {
            this.MightPower = MightPower;
        }

        public int MightPower { get; set; }

        public override string ToString() => string.Format("MagicHero {0} | {1} | {2}", Name, MightPower, base.GetSkills());
    }

    class MightHero : Hero
    {
        public MightHero(string Name, int MightPower): base(Name)
        {
            this.MightPower = MightPower;
        }

        public int MightPower { get; set; }

        public override string ToString() => string.Format("MagicHero {0} | {1} | {2}", Name, MightPower, base.GetSkills());
    }

    class MageGuild<T> where T : Hero
    {
        T HeroItem;
        string skill;

        public MageGuild(string skill)
        {
            this.skill = skill;
        }

        public void ComeIn(T obj)
        {
            HeroItem = obj;
            Console.WriteLine("Hello, {0}", HeroItem.Name);
        }

        public void TeachSkill()
        {
            HeroItem.AddSkill(skill);
            Console.WriteLine("{0} learned new skill {1}", HeroItem.Name, skill);
        }

        public void ComeOut()
        {
            Console.WriteLine("By, {0}", HeroItem.Name);
            HeroItem = null;
        }

    }

    class ProgramHeroes
    {
        static void Main(string[] args)
        {
            MightHero magneta = new MightHero(Name: "Magneta", MightPower: 5);
            Console.WriteLine(magneta.ToString());
            MageGuild<Hero> mageGuildFire = new MageGuild<Hero>("Fire");
            mageGuildFire.ComeIn(magneta);
            mageGuildFire.TeachSkill();
            Console.WriteLine(magneta);
            mageGuildFire.ComeOut();
            MageGuild<Hero> mageGuildWater = new MageGuild<Hero>("Water");
            mageGuildWater.ComeIn(magneta);
            mageGuildWater.TeachSkill();
            mageGuildWater.ComeOut();
            Console.WriteLine(magneta);

            MagicHero Modest = new MagicHero(Name: "Modest Petrovich", MightPower: 100);

            mageGuildWater.ComeIn(Modest);
            mageGuildWater.TeachSkill();
            mageGuildWater.ComeOut();
            mageGuildFire.ComeIn(Modest);
            mageGuildFire.TeachSkill();
            mageGuildFire.ComeOut();

            Console.WriteLine(Modest);

            Console.ReadKey();
        }
    }
}
