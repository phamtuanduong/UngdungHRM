   M S B A M L   `   `   `  ����E  AUngdungHRM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:UngdungHRM.FilterControlUngdungHRM.FilterControl  5      .    (UngdungHRM.FilterControl.filter_NhanVien   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:UngdungHRM.FilterControl     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      $	��193��5	   #   .��5
      �   � RowDefinitions  5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   ��  0  ,MaterialDesignFilterChipAccentOutlineListBox#��[  6   ���	#DDFF0000$��0 0 0 5q�5      $
��Left=�5      .@�5      �� -   5         ��Name$ 
lsItemMaNv��5       �� 
IsSelected . .��6@   Theo mã nhân viên5      �� 5      -   5        $ lsItemTenNv��5      .��5      Theo tên nhân viên5      5      �� 5    
   $��1��6   $��0 10 0 0q�6"   .+�5!      �� $��Theo tên công việc��6   $��1��5"      $��5 10 0 0q�5#      $��	Yu Gothic)�6&   �� 5$      -   5         ��Name$ cbChucVu��5%      $��5 0 15 0q�5$       �� DisplayMemberPath$
 Name��5&       �� SelectedValuePath$
 Name��5)      ��5'      ��  �� SelectedValue 5*      �� *Name+ �� Text 5+      �� *Name+ �� UpdateSourceTrigger$ PropertyChanged=�5-      �� 5/   
   $��2��6   $��0 10 0 0q�6"   .+�50      �� $��Theo trạng thái��6   $��5 0 0 0q�52      $��	Yu Gothic)�6%   �� 53      -   5        $ cbTinhTrang��55      $��2��54      $��5 0 15 0q�6   $
 Name��56      $
 Name��57       58      �� *Level+ 5:      �� *Level+$ PropertyChanged=�5<      �� 5>   
   $��4��6   .+�5?      �� -   5        	 ��Name$	 txtSearchInput��5D       * &MaterialDesignOutlinedTextFieldTextBox#��[ 5?      $��	5 10 15 0q�5@      )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Tìm kiếm��5A      
�������.��5D   .   5F      �� 5H      -   5         ��Name$ btnXoa��5L         MaterialDesignOutlinedButton#��[ 5H      $��Right=�5I      $��0 0 15 0q�5J      $��15��5K      $
��15 0q�6!   $y�	Collapsed=�5M      .��5O      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�6*   
�������67   5P      5Q      5S      5T      