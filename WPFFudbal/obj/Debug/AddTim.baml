   M S B A M L   `   `   `  ����D  @WPFFudbal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:WPFFudbal	WPFFudbal  5   	       WPFFudbal.AddTim   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:WPFFudbal     5   	     � Title$  AddTim��5   	   $	��450��6   $	��800��6%   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $��6 �6   �� 5      $��138.1 �6   �� 5      $
��13.1 �6   �� 5      $��6 �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $��6 �6   �� 5      $
��auto �6   �� 5      $��6 �6   �� 5      $
��auto �6   �� 5      $��6 �6   �� 5      $
��auto �6   �� 5      $��6 �6   �� 5      $
��auto �6   �� 5      $��6 �6   �� 5      $
��auto �6   �� 5       $��20 �6   �� 5!      $
��auto �6   �� 5"      $��20 �6   .+�5%   
   �� -   5        $��lblName��5%   -   $��1��6   $��1��6    $
��Tim:��6<   $	��0.2q�6K   �� 5&   
   -   5        $��lblPlace��5&   -   $��1��6   $��3��6    $��Sediste:��6=   $	��0.2q�6P   �� 5'   
   -   5        $��lblBirth��5'   -   $��1��6   $��5��6    $��Osnovan:��6=   $	��0.2q�6P   �� 5(   
   -   5        $��	lblLeague��5(   -   $��1��6   $��7��6    $��Liga:��6>   $	��0.2q�6N   �� 5*   
   -   5        $��txtName��5*   /   $��3��6   $��1��6"   $��20��6>   $	��150��6J   $��2��5+   S   $��0.6,3.2q�6g   ��6   �� *	Tim.naziv+ �� UpdateSourceTrigger$ PropertyChanged=�6g   �� 5,   
   -   5        $��txtPlace��5,   /   $��3��6   $��3��6"   $��20��6@   $	��150��6L   $��2��6X   $��0.6,3.6,0.6,2.8q�6l   ��5-      �� *Tim.sediste+$ PropertyChanged=��� 5.   
   -   5        $��txtBirth��5.   /   $��3��6   $��5��6"   $��20��6@   $	��150��6L   $��2��6X   $��0.6,3.6,0.6,2.8q�6l   ��5/      �� *Tim.osnovan+$ PropertyChanged=��� 51   
   -   5        $��cmbNac��51   0   $��3��6   $��7��6#   $��20��6>   $	��150��6J    �� Text$ Please select liga��6V    �� DisplayMemberPath$ naziv��6q    �� 
IsEditable . $��2��53   V   $��0.6,3,0.6,3.4q�6j   ��52      �� *	ListaLiga+$ PropertyChanged=� �� SelectedItem 53      �� *Liga+$ PropertyChanged=�6j   �� 54   
   -	   5        $��btnSave��54   .   $��3��6   $��9��6!   $
��Save��6=   $��20��6L   $	��150��6X   $
��Bold"�6d   ��55      �� *Save+$ PropertyChanged=�56      57      