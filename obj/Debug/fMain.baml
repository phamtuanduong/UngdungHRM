   M S B A M L   `   `   `  ����E  AUngdungHRM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:UngdungHRM
UngdungHRM  5   	   ?$clr-namespace:UngdungHRM.NewControlsUngdungHRM.NewControls  5   	       UngdungHRM.fMain   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:UngdungHRM     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -uc$clr-namespace:UngdungHRM.NewControls  5   	     � Title$  fMain��5	   	   $	��650��6   $
��1170��6$    � WindowStartupLocation$ CenterScreen=�5
   	    � WindowStyle$
 None=�6.    � AllowsTransparency . 
������ .��5      )  #MaterialDesignThemes.Wpf.DialogHost  -   5          Name$ 
dialogHost��5          DialogContent 5   
   � 5      -   5         �Name$ dialogHostControl��5      6.   .��5   
   �� ���#F6F6FE �� CornerRadius$ 20��5      ���	#7F8387F5$��1q�5      ._�5      �  � RowDefinitions 5      �� 5      $��0.15* �6$   �� 5      $��* �6$   	 � ColumnDefinitions	 5      �� 5      $
��0.2* �6'   �� 5      $��* �6'   .+�5"      �� -   5        $��2��5"      ���#8387F5$ 	20 20 0 0��5$      ._�5&      � -   5        $ 
barControl��5&      $��	195 5 0 0q�60   .+�5'      �� 
 �� Orientation$
 
Horizontal=�6%   .+�5(      	� -   5            MaterialDesignTabRadioButton#��[  5(   *   
������� d� 	IsChecked$
 TrueY�5)   9   $��	15 0 15 0q�5*   &   $��Comic Sans MS)�5,   c   $��16(�6~   ��6&   ��  �� ElementName$ 
barControl�� �� Path$ ActualHeight�.��6�   Quản trị viên5.      	� 50      -   5        #��[  50   *   
�������$��	15 0 15 0q�52   &   $��Comic Sans MS)�54   c   $��16(�6~   ��6&   �� $ 
barControl��$ ActualHeight�.��6�   Quản lý nhân viên56      	� 58      -   5        #��[  58   *   
�������$��	15 0 15 0q�5:   &   $��Comic Sans MS)�5<   c   $��16(�6~   ��6&   �� $ 
barControl��$ ActualHeight�.��6�   Nghỉ phép5>      	� 5@      -   5        #��[  5@   *   
�������$��	15 0 15 0q�5B   &   $��Comic Sans MS)�5D   c   $��16(�6~   ��6&   �� $ 
barControl��$ ActualHeight�.��6�   Công việc5F      	� 5H      -	   5        #��[  5H   *   
�������$��	15 0 15 0q�5J   &   $��Comic Sans MS)�5L   c   $��16(�6~   ��6&   �� $ 
barControl��$ ActualHeight�.��6�   Tuyển dụng5N      5O      �� 5Q      $��0 0 15 0q�6%   $��Right=�67   $
 
Horizontal=�6S   .+�5R      �� $��40��6%   $��40��61     MaterialDesignIconButton#��[ 5S       ���	#7FE6E6E6
�������.��5U   "   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Magnify=�5V   !   5W      �� 5Y      $��	15 0 10 0q�6%   $��45��68   $��45��6D   #��[ 5Z   %   $��0q�5[   %   ���	#FFB5B7EE.��5\   "   �� -
   5         ��Name$ img_avt��5\   (   $��45��69   $��45��6E   $$��icon/icons8_guarantee_40px.png��6P   $��UniformToFill=�6x   5]   +   5^      �� 5`      $��Center=�6)   .+�5a   "   �� -   5         ��Name$ txtName��5a   ,   $��Phạm Tuấn Dương��6=   
�������$��Calibri)�6g   $
��Bold"�6|   �� 5b   "   -   5        $ txtClock��5b   ,   $��15/10/2020 2:38PM��6>   
�������$��Italic$�6j   5c      5e      5f      5g      �� 5k      -   5         ��Name$ 	borderNav��5k      $��2��6,   
�������$ 
20 50 0 20��5m       J� Effect 5n      3  -System.Windows.Media.Effects.DropShadowEffect  5o         
BlurRadius$ 5Q�6+      ShadowDepth$ 1Q�6:      	Direction$	 270Q�6J     MaterialDesignShadow   Color# [ 6Z      Opacity$	 .42Q�6�      RenderingBias$ Performance=�6�   5q      � 5s      $��1��6    5t      �� 5u      �� 5v      .+�5y      ��  �� Padding$ 5 5 5 0q�6   ._�5{      � -   5        $ 	filterNav��5{      5}      �� 5      $��1��6!   .+�5�      �� $
��10 0q�6$     MaterialDesignDarkSeparator#���  62   �� 5�      $��Khởi động nhanh��6$   $��
10 0 10 10q�5�       $��13(�64    # MaterialDesignOverlineTextBlock#���  5�       ���	#FFC1C0C06Z   � 5�      -   5         �Name$ wrapPanelQuick��5�   $   $��Center=�6<   $y�Hidden=�5�   %   .+�5�      �� $��65��6%   $��65��61     MaterialDesignFlatButton#��[ 6<    � ToolTip$" Chỉnh định nghỉ phép��5�   !   .��5�   "   �� $��34��6(   $��34��64   $��icon/ApplyLeave.png��6?   5�      �� 5�      $��65��6%   $��65��61   #��[ 6<   $" Chỉnh định nghỉ phép��5�   !   .��5�   "   �� $��34��6(   $��34��64   $��icon/MyLeave.png��6?   5�      �� 5�      $��65��6%   $��65��61   $��0 10 0 0q�6<   #��[ 6N   $" Chỉnh định nghỉ phép��5�   !   .��5�   "   �� $��34��6(   $��34��64   $��icon/MyTimesheet.png��6?   5�      %  MaterialDesignThemes.Wpf.Badged  5�      $��0 10 0 0q�5�        ControlzEx.BadgedEx   Badge$ 0��5�         BadgeBackground �	#FF89EA46
�������.��5�   "   �� $��65��6)   $��65��65   #��[ 6@   $" Chỉnh định nghỉ phép��5�   !   .��5�   &   �� $��34��6,   $��34��68   $��icon/ApplyLeave.png��6C   5�   #   5�      5�      �� 5�      $
��10 0q�6$   #���  62   �� 5�      $��Center=�6%   $
 
Horizontal=�6B   $��0 10 0 0q�5�   !   .+�5�      ��  & "MaterialDesignIconForegroundButton#��[ 6%      MaterialDesignToolForeground#���  5�   !   $' !Đăng xuất khỏi ứng dụng��5�   !   .��5�   "     $ Logout=�6:   5�      �� 5�      $��15 0 0 0q�6%   #��[ 67   #���  5�   !   $ Cài đặt��5�   !   .��5�   "     $ Settings=�6:   5�      5�      5�      5�      �� 5�      -   5        
������ ._�5�      � .+�5�      �� $
 
Horizontal=�6%   $	��Top=�5�   !   $��	10 10 0 0q�5�   !   .+�5�      �� -   5         # MaterialDesignFlatLightBgButton#��[ 5�   %   ���	#CCFF6058
������ +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 19��5�   !   $��15��5�   !   $��15��6-   �� 5�      #��[ 6%   ���	#CCFFBF2F
������ $ 19��5�   !   $��15��5�   !   $��15��6-   $��2 0 0 0q�68   �� 5�      #��[ 6%   ���	#CC3BCF45
������ $ 19��5�   !   $��15��5�   !   $��15��6-   $��2 0 0 0q�68   5�      �� 5�      $��Bottom=�6$   $��0 0 0 20q�5�   $   #��[ 5�   $   �� 5�      $��Lọc��6$    $	  MaterialDesignHeadline3TextBlock#��[	 6/   $��20(�5�       $��10 0 0 0q�6.   $��Bottom=�5�       ���	#FF787878$��Yu Gothic UI)�6R   5�      5�      � 5�      -   5        $ gridControl��5�      $��2��5�      $��2��6$   .+�5�      0   *UngdungHRM.NewControls.userControlPageHome  5�      5�      5�      5�      5�      