   M S B A M L   `   `   `  ����D  @WPFFudbal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:WPFFudbal	WPFFudbal  5   	       WPFFudbal.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:WPFFudbal     5   	     � Title$  Fudbalski Savez Srbije��5   	   $	��450��6(   $	��950��65   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $��6 �6   �� 5      $
��auto �6   �� 5      $��0 �6   �� 5      $
��auto �6   $��6��6,   �� 5      $��0 �6   �� 5      $
��auto �6   $��6��6,   �� 5      $��6 �6   �� 5      $
��auto �6   �� 5      $��6 �6   �� 5      $��6 �6   �� 5      $
��auto �6   �� 5      $��6 �6   �� 5      $
��auto �6   �� 5      $��9.731 �6   �� 5      $��11.269 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5       $��6 �6   �� 5!      $
��auto �6   �� 5"      $��6 �6   �� 5#      $
��auto �6   �� 5$      $��6 �6   �� 5%      $
��auto �6   �� 5&      $��6 �6   �� 5'      $
��auto �6   �� 5(      $��6 �6   �� 5)      $
��auto �6   �� 5*      $��20 �6   .+�5-   
   � $��2��6   $��1��6   $
��auto��6,   $
��auto��6:   $��5��6G   $��6.8,0.2,29.4,36.6q�6[   $��2��6v   .+�5.      &   System.Windows.Controls.DataGrid  -   5        $��DataGridIgrac��5.         
IsReadOnly .    HeadersVisibility$ Column=�52         AutoGenerateColumns .     HorizontalGridLinesBrush
 �   �
���   �
���   �$
��Bold"�55   *   $��0,0,161,-176q�6<   $	��250��6R   $	��300��6_   ��5.   ,   �� *	IgracList+ �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem 5/      �� *Igrac+$ PropertyChanged=�y�50      �� *	ViewIgrac+$ PropertyChanged=�	   Columns	 56      0  *System.Windows.Controls.DataGridTextColumn  57      ,  &System.Windows.Controls.DataGridColumn
   Header$
 ID��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *ID+$ PropertyChanged=�  58      $	
 Ime��6)    66   �� *ime+$ PropertyChanged=�  59      $
 Prezime��6)    6:   �� *	prezime+$ PropertyChanged=�  5:      $
 Nacionalnost��6)    6?   �� *nazNac+$ PropertyChanged=�  5;      $	
 Tim��6)    66   �� *nazTim+$ PropertyChanged=�  5<      $

 Cena��6)    67   �� *cena+$ PropertyChanged=�5>        5?      -   5        $��DataGridTim��5?       . $ Column=�5C       .  
 �   �
���   �
���   �$
��Bold"�5F   *   $��0,0,161,-176q�6<   $	��250��6R   $	��300��6_   ��5?   *   �� *	TimList+$ PropertyChanged=� 5@      �� *Tim+$ PropertyChanged=�y�5A      �� *	ViewTim+$ PropertyChanged=�	 5G        5H      $
 ID��6)    65   �� *ID+$ PropertyChanged=�  5I      $
 Naziv��6)    68   �� *naziv+$ PropertyChanged=�  5J      $
 Sediste��6)    6:   �� *	sediste+$ PropertyChanged=�  5K      $
 Osnovan��6)    6:   �� *	osnovan+$ PropertyChanged=�  5L      $

 Liga��6)    67   �� *	nazLige+$ PropertyChanged=�5N        5O      -   5        $��DataGridLiga��5O       . $ Column=�5S       .  
 �   �
���   �
���   �$
��Bold"�5V   *   $��0,0,161,-176q�6<   $	��250��6R   $	��300��6_   ��5O   +   �� *
LigaList+$ PropertyChanged=� 5P      �� *Liga+$ PropertyChanged=�y�5Q      �� *
ViewLiga+$ PropertyChanged=�	 5W        5X      $
 ID��6)    65   �� *ID+$ PropertyChanged=�  5Y      $
 Naziv��6)    68   �� *naziv+$ PropertyChanged=�  5Z      $
 Oznaka��6)    69   �� *oznaka+$ PropertyChanged=�  5[      $
 
Kategorija��6)    6=   �� *nazKat+$ PropertyChanged=�5]      5^      �� 5`   
   $��5��6   $��1��6%    �� Orientation$ Vertical=�62   $��2��6I   $��6,0.2,0.4,7q�6]   $��2��6r   y�5a      �� *	ViewIgrac+$ PropertyChanged=�.+�5b      �� -   5        $��btnAddCashRegister��5b   -   $	��120��6   $��30��6!   $��	Add igrac��6G   $
��Bold"�5c   Z   $��5q�6l   $��2q�6w   ��6   �� *AddNewIgrac+$ PropertyChanged=�6w   �� 5d      -   5        $��btnEditCashRegister��5d   -   $	��120��6   $��30��6!   $��Edit igrac  ��6H   $
��Bold"�5f   X   $��5q�6j   $��2q�6u   y�5e      �� *	ViewIgrac+$ PropertyChanged=���5f      �� *	EditIgrac+$ PropertyChanged=�6u   �� 5g      -   5        $��btnDeleteCashRegister��5g   -   $	��120��6   $��30��6!   $��Delete igrac ��6J   $
��Bold"�5i   Z   $��5q�6l   $��2q�6w   y�5h      �� *	ViewIgrac+$ PropertyChanged=���5i      �� *DeleteIgrac+$ PropertyChanged=�6w   5m      �� 5o   
   $��5��6   $��1��6%   $ Vertical=�62   $��2��6I   $��6,0.2,0.4,7q�6]   $��2��6r   y�5p      �� *	ViewTim+$ PropertyChanged=�.+�5q      �� -   5        $��	btnAddTim��5q   -   $	��120��6   $��30��6!   $��Add tim��6>   $
��Bold"�5r   U   $��5q�6g   $��2q�6r   ��6   �� *AddTim+$ PropertyChanged=�6r   �� 5s      -   5        $��
btnEditTim��5s   -   $	��120��6   $��30��6!   $��Edit tim��6?   $
��Bold"�5u   V   $��5q�6h   $��2q�6s   y�5t      �� *	ViewTim+$ PropertyChanged=���5u      �� *	EditTim+$ PropertyChanged=�6s   �� 5v      -	   5        $��btnDeleteTim��5v   -   $	��120��6   $��30��6!   $��Delete tim ��6A   $
��Bold"�5x   X   $��5q�6j   $��2q�6u   y�5w      �� *	ViewTim+$ PropertyChanged=���5x      �� *	DeleteTim+$ PropertyChanged=�6u   5y      �� 5{   
   $��5��6   $��1��6%   $ Vertical=�62   $��2��6I   $��6,0.2,0.4,7q�6]   $��2��6r   y�5|      �� *
ViewLiga+$ PropertyChanged=�.+�5}      �� -
   5        $��
btnAddLiga��5}   -   $	��120��6   $��30��6!   $��Add liga��6?   $
��Bold"�5~   V   $��5q�6h   $��2q�6s   ��6   �� *	AddLiga+$ PropertyChanged=�6s   �� 5      -   5        $��btnEditLiga��5   -   $	��120��6   $��30��6!   $��	Edit liga��6@   $
��Bold"�5�   W   $��5q�6i   $��2q�6t   y�5�      �� *
ViewLiga+$ PropertyChanged=���5�      �� *
EditLiga+$ PropertyChanged=�6t   �� 5�      -   5        $��btnDeleteLiga��5�   -   $	��120��6   $��30��6!   $��Delete liga ��6B   $
��Bold"�5�   Y   $��5q�6k   $��2q�6v   y�5�      �� *
ViewLiga+$ PropertyChanged=���5�      �� *
DeleteLiga+$ PropertyChanged=�6v   5�      �� 5�   
   $��1��6   $��1��6%   $ Vertical=�62   .+�5�      �� -   5        $��btnManageIgrac��5�   -   $	��160��6   $��20��6!   $��Manage igrac��6C   $��5q�6Z   $
��Bold"�5�   Z   ��6   �� *ManageIgrac+$ PropertyChanged=�6Z   �� 5�      -   5        $��btnManageTim��5�   -   $	��160��6   $��20��6!   $��
Manage tim��6A   $��5q�6V   $
��Bold"�5�   W   ��6   �� *	ManageTim+$ PropertyChanged=�6W   �� 5�      -   5        $��btnManageLiga��5�   -   $	��160��6   $��20��6!   $��Manage liga��6B   $��5q�6X   $
��Bold"�5�   X   ��6   �� *
ManageLiga+$ PropertyChanged=�6X   5�      �� 5�   
   $	��200��6   $	��150��6   $��2��6)   $��7��6=   $��9.8,0.2,-134.2,15q�6M   $��1��6h   $��12��6u   ��5�      �� 5�       �� 	UriSource$ /Images/fss.png?�6   5�      5�      5�      