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

        public string GetList(string list)
        {
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

            return list + " doesn't exist.\n";
        }

        public string Add(string list, string tag)
        {

            if (list == "Cast")
            {
                if (cast.Contains(tag))
                {
                    completed = false;
                }
                else
                {
                    cast.Add(tag);
                    completed = true;
                }
            }
            else if (list == "Company")
            {
                if (companies.Contains(tag))
                {
                    completed = false;
                }
                else
                {
                    companies.Add(tag);
                    completed = true;
                }
            }
            else if (list == "Genre")
            {
                if (genres.Contains(tag))
                {
                    completed = false;
                }
                else
                {
                    genres.Add(tag);
                    completed = true;
                }
            }
            else if (list == "Rating")
            {
                if (ratings.Contains(tag))
                {
                    completed = false;
                }
                else
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
            if (list == "Cast")
            {
                if (cast.Contains(tag))
                {
                    cast.Remove(tag);
                    completed = true;
                }
                else
                {
                    completed = false;
                }
            }
            else if (list == "Company")
            {
                if (companies.Contains(tag))
                {
                    companies.Remove(tag);
                    completed = true;
                }
                else
                {
                    completed = false;
                }
            }
            else if (list == "Genre")
            {
                if (genres.Contains(tag))
                {
                    genres.Remove(tag);
                    completed = true;
                }
                else
                {
                    completed = false;
                }
            }
            else if (list == "Rating")
            {
                if (ratings.Contains(tag))
                {
                    ratings.Remove(tag);
                    completed = true;
                }
                else
                {
                    completed = false;
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
