using mike.models;
using System.Collections.Generic;
using System.Linq;

namespace mike.data
{
    public class InMemorySectionData : ISectionData
    {
        public InMemorySectionData()
        {
            _sections = new List<Section>()
            {
                new Section
                {
                    SectionId = 1,
                    Header = "Extracurricular / Hobbies (InMemory)",
                    Content = @"I’m passionate about learning new skills, and improving upon those I already have.  Currently, I am learning aspnet core, dotnet core, python and machine learning in my free time.  I attended the M-Cubed data-science conference in 2018 to further my exposure to ML. 
I’m also interested in DevOps/CI/CD, and so I’ve spent some time looking into Docker / Kubernetes (minikube) / Jenkins / Ansible.  Whilst this isn’t my area of expertise, I am interested in learning more, and plan on spending more time in this domain.
I try to keep up - to - date by viewing the Thoughtworks’ Tech - Radar, and generally following Martin Fowler and reading his books; such as Continuous Delivery, and Accelerate.  I’m also making my way through the new C# in Depth 4th Edition by the legendary Jon Skeet, and have the older CLR via C# on my backlog.  I also use tech blog aggregators, such as The Morning Brew, by Chris Alcock.
I enjoy playing foosball, board games, and rocket league, I also enjoy climbing, running, yoga, and spending time with my family."
                },
                new Section
                {
                    SectionId = 2,
                    Header = "Header 2",
                    Content = "Saepe aut non quod hic commodi. Tempore et et consequatur soluta. Facere aut ipsam dolorum et accusamus.  Iusto facere incidunt consequatur et illum molestias. Recusandae sed odio eveniet iusto doloribus molestias officiis. In tempore ut commodi cumque. Eligendi commodi est quia magnam.  At accusantium natus accusantium. Ut nobis qui quaerat doloremque accusantium eaque vero. Quaerat laborum facere deserunt aliquam. Enim doloribus iusto laboriosam qui. Id laudantium neque tempore et dolorem. Et repellat ullam occaecati ut facilis consequatur velit dolorem."
                },
                new Section
                {
                    SectionId = 3,
                    Header = "Header 3",
                    Content = "Beatae unde est quisquam qui consequatur. Tempora aut nesciunt sunt ut sed dolores. Velit magni dignissimos soluta qui eaque ut aut. Totam occaecati et explicabo sed optio eaque praesentium. Quis dolore asperiores veritatis iure quasi numquam non dolorem. Molestiae qui ducimus et non quisquam aut explicabo veritatis.",
                    Subsections = new List<Section>
                    {
                        new Section
                        {
                            SectionId = 4,
                            ParentSectionId = 3,
                            Header = "Section 3a",
                            Content = "Distinctio quis dolorem nisi inventore voluptas exercitationem. Velit iure enim ut quo eos sequi deleniti. Temporibus ut ullam corrupti ab labore nostrum."
                        },
                        new Section
                        {
                            SectionId = 5,
                            ParentSectionId = 3,
                            Header = "Section 3b",
                            Content = "Aliquid qui praesentium minus vel quidem. Provident eum distinctio asperiores quo ut modi. Sit tempore est reiciendis dolor itaque magnam asperiores. Rem dolore perspiciatis nihil cumque beatae tenetur. Nihil mollitia cupiditate similique."
                        },
                        new Section
                        {
                            SectionId = 6,
                            ParentSectionId = 3,
                            Header = "Section 3c",
                            Content = "Neque quis veritatis ipsum exercitationem quam rem maiores at. Impedit quis autem consequatur enim perferendis officiis quia est. Commodi assumenda cum corporis debitis id reprehenderit sit. Dolorum consequatur autem facilis quis quaerat."
                        }
                    }
                }
            };
        }

        public IEnumerable<Section> GetAll()
        {
            return from section in _sections
                   orderby section.Header
                   select section;
        }

        public IEnumerable<Section> GetByContent(string content)
        {
            return from section in _sections
                   where string.IsNullOrEmpty(section.Content) || section.Content.Contains(content)
                   orderby section.Header
                   select section;
        }

        private readonly List<Section> _sections;
    }
}
