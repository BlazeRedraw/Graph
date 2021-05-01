using System.Collections.Generic;

namespace Graph
{
    internal class Tags
    {
        public string text;
        public bool completed;
        public List<string> cast = new List<string>();
        public List<string> companies = new List<string>();
        public List<string> genres = new List<string>();
        public List<string> ratings = new List<string>();

        public Tags()
        {

        }

        public string Search(string list)
        {
            list = list.Trim();

            if (list == "Cast")
            {
                text = string.Join(", ", cast);

                if (text != "")
                {
                    text = text.TrimEnd(' ');
                    text = text.TrimEnd(',') + ".\n";
                    return text;
                }
            }
            else if (list == "Company")
            {
                text = string.Join(", ", companies);

                if (text != "")
                {
                    text = text.TrimEnd(' ');
                    text = text.TrimEnd(',') + ".\n";
                    return text;
                }
            }
            else if (list == "Genre")
            {
                text = string.Join(", ", genres);

                if (text != "")
                {
                    text = text.TrimEnd(' ');
                    text = text.TrimEnd(',') + ".\n";
                    return text;
                }
            }
            else if (list == "Rating")
            {
                text = string.Join(", ", ratings);

                if (text != "")
                {
                    text = text.TrimEnd(' ');
                    text = text.TrimEnd(',') + ".\n";
                    return text;
                }
            }

            return list + " is empty.\n";
        }

        public string Add(string list, string tag)
        {
            list = list.Trim();
            tag = tag.Trim();
            completed = false;

            if (list == "Cast")
            {
                if (!cast.Contains(tag))
                {
                    cast.Add(tag);
                    completed = true;
                }
            }
            else if (list == "Company")
            {
                if (!companies.Contains(tag))
                {
                    companies.Add(tag);
                    completed = true;
                }
            }
            else if (list == "Genre")
            {
                if (!genres.Contains(tag))
                {
                    genres.Add(tag);
                    completed = true;
                }
            }
            else if (list == "Rating")
            {
                if (!ratings.Contains(tag))
                {
                    ratings.Add(tag);
                    completed = true;
                }
            }
            else
            {
                return "'" + list + "' doesn't exist.\n";
            }

            if (completed)
            {
                return "Succesfully added '" + tag + "' to '" + list + "'.\n";
            }
            else
            {
                return "'" + tag + "' already exists in '" + list + "'.\n";
            }
        }
        public string Remove(string list, string tag)
        {
            list = list.Trim();
            tag = tag.Trim();
            completed = false;

            if (list == "Cast")
            {
                if (cast.Contains(tag))
                {
                    cast.Remove(tag);
                    completed = true;
                }
            }
            else if (list == "Company")
            {
                if (companies.Contains(tag))
                {
                    companies.Remove(tag);
                    completed = true;
                }
            }
            else if (list == "Genre")
            {
                if (genres.Contains(tag))
                {
                    genres.Remove(tag);
                    completed = true;
                }
            }
            else if (list == "Rating")
            {
                if (ratings.Contains(tag))
                {
                    ratings.Remove(tag);
                    completed = true;
                }
            }
            else
            {
                return "'" + list + "' doesn't exist.\n";
            }

            if (completed)
            {
                return "Succesfully removed '" + tag + "' from '" + list + "'.\n";

            }
            else
            {
                return "'" + tag + "' doesn't exist in '" + list + "'.\n";
            }
        }
    }
}
