   M S B A M L   `   `   `  ���� G  CNewsPressApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:NewsPressAppNewsPressApp  $    NewsPressApp.SiteDetail_Report   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ,localclr-namespace:NewsPressApp       N� Title$  SiteDetail_Report��.���� -    ��Name$ stkPanelReport�� �� Orientation$ Vertical=�.+��� $
��0,10q�$��43��$	��867��$ 
Horizontal=�$��Right=�.+��� $��Başlangıç Tarihi��$	��119��$��Center=�(  "System.Windows.Controls.DatePicker  -     Name$ datepickerStart��$	��109��$��28��   SelectedDateFormat$ Short=��� $��Bitiş Tarihi��$��	40,0,0,10q�$��98��$��Bottom=�$��32��  -   $ datepickerEnd��$	��127��$��Center=��� -   $��Uygula��$��10q��� $ 
Horizontal=�$	��180��$	��995��.+��� $ Vertical=�$	��176��$	��421��.+��� $��İçerik Sayısı��$	��307��$��46��$��20(�$��10q�$��0q�&   System.Windows.Controls.DataGrid  -     Name$ 	dtgNumAll��   CanUserAddRows$ False��   
IsReadOnly$
 True��$
��Auto��$��30(�$
��Auto��   HeadersVisibility$
 None=�$��Center=��� $	��173��$	��421��$��50,00,10,10q�.+��� $��Haber Sayısı��$	��307��$��46��$��20(�$��10q�$��0q�  -   $ 
dtgNumNews��$ False��$
 True��$
��Auto��$��30(�$
��Auto��$
 None=�$��Center=��� $ 
Horizontal=�$	��187��$	��996��$
��Left=�.+��� $	��192��$	��421��.+��� $��Köşe Yazısı Sayısı��$	��307��$��46��$��20(�$��10q�$��0q�  -   $ dtgNumColumn��$ False��$
 True��$
��Auto��$��30(�$
��Auto��$
 None=�$��Center=��� $	��192��$	��421��$��50,00,10,10q�.+��� $��Video Sayısı��$	��307��$��46��$��20(�$��10q�$��0q�  -   $ dtgNumVideo��$ False��$
 True��$
��Auto��$��30(�$
��Auto��$
 None=�$��Center=�