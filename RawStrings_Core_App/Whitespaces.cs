﻿namespace RawStrings_Core_App;

public class Whitespaces
{
    public void Test()
    {
        var s1 = """   
    
    """;

        var xml = """
          <element attr="content">
              <body>
              ""test body text""{Whitespaces.cs}
              </body>

          </element>
          """;

        var v1 = """
         Start
          
         End
         """;

//        var stringFromBlazor = """
//                        <!DOCTYPE html>
//<html lang="en">
//<head>
//    <meta charset="utf-8"/>
//    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
//    <base href="~/"/>
//    <link rel="stylesheet" href="css/bootstrap/bootstrap.min.css"/>
//    <link href="css/site.css" rel="stylesheet"/>
//    <link href="RawString_Blazor.styles.css" rel="stylesheet"/>
//    <link rel="icon" type="image/png" href="favicon.png"/>
//    <component type="typeof(HeadOutlet)" render-mode="ServerPrerendered"/>
//</head>
//<body>
//<component type="typeof(App)" render-mode="ServerPrerendered"/>

//<div id="blazor-error-ui">
//    <environment include="Staging,Production">
//        An error has occurred. This application may no longer respond until reloaded.
//    </environment>
//    <environment include="Development">
//        An unhandled exception has occurred. See browser dev tools for details.
//    </environment>
//    <a href="" class="reload">Reload</a>
//    <a class="dismiss">🗙</a>
//</div>

//<script src="_framework/blazor.server.js"></script>
//</body>
//</html>

//            """;


        var xml2 = """
          <element attr="content">
            <body>
            </body>
          </element>
""";

        var empty = """

""";
    }
}