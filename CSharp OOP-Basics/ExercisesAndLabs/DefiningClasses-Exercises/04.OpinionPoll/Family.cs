namespace _04.OpinionPoll
{
    using System.Collections.Generic;
    using System.Linq;

    public class Family
    {
        private List<Person> members;

        public Family()
        {
            this.members = new List<Person>();
        }

        public void AddMember(Person member)
        {
            this.members.Add(member);
        }

        public List<Person> FilterAndSort()
        {
            return this.members.Where(x => x.age > 30).OrderBy(x => x.name).ToList();
        }
    }
}