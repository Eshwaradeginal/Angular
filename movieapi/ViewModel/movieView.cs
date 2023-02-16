using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieService.ViewModel
{
 public class Actor
  {
    public int ACTID { get; set; }
    public string ACTNAME { get; set; }
  }

  public class Director
  {
    public int DIRID { get; set; }
    public string DIRNAME { get; set; }
  }

  public class Movies
  {
    public int MOVID { get; set; }
    public string MOVTITLE { get; set; }
    public Nullable<int> MOVYEAR { get; set; }
    public string MOVLANG { get; set; }
    public Nullable<int> DIRID { get; set; }
    public string Image { get; set; }
  }

  public class Moviecast
  {
    public int ACTID { get; set; }
    public int MOVID { get; set; }
    public string ROLE { get; set; }
  }
}
