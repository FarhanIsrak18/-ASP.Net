Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        ViewData("name") = "Farhan Israk mahmud"
        ViewData("email") = "shahidinfo.45@gmail.com"

        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function
    Function Personal() As ActionResult
        ViewData("Number") = "01857905161"
        ViewData("age") = "24"
        ViewData("address") = "D block,road#4,house#43/g"
        ViewData("gender") = "Male"
        Return View()
    End Function
    Function Education() As ActionResult
        ViewData("University") = "AIUB"
        ViewData("Cgpa") = "Running...(3.5)"
        ViewData("College") = "MBHSC"
        ViewData("Hgrade") = "Passed(4.42)"
        ViewData("School") = "Shaheen Academy school feni"
        ViewData("grade") = "Passed(4.89)"
        Return View()
    End Function
End Class
