   M S B A M L   `   `   `  ����E  AUngdungHRM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:UngdungHRM.NewControlsUngdungHRM.NewControls  5      7    1UngdungHRM.NewControls.quanlinhanvien_controlItem   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:UngdungHRM.NewControls     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        � 	Resources  5
         ShowMessage �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value��%�  &	        �� 5   
   .��5      U� $ (UIElement.Opacity)�6,   $
 Mess��6\   .\�5        $ 0��6'   $ 0Q�63     5      $ 0:0:0.1��6E   $	 0.2Q�6W     5      $ 0:0:0.3��6'   $ 1Q�69     5      $ 0:0:0.9��6'   $ 1Q�69     5      $ 0:0:1.5��6'   $	 0.7Q�69     5      $ 0:0:1.6��6'   $	 0.5Q�69     5      $ 0:0:1.7��6'   $ 0Q�69   5      5      5      .��5      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffects 5   
   ;  5MaterialDesignThemes.Wpf.Transitions.TransitionEffect  5         Kind$ FadeIn=�6.     5      $ SlideInFromRight=�6.   .��5   
   ��  �� Padding$ 20 10 20 10q�6   ._�5      �  � RowDefinitions 5       �� 5!      $
��Auto �6$   �� 5"      $��* �6$   .+�5%      �� 	 �� CornerRadius$	 10��6   $ 10q�6+   ���#EFEFEF
 J� Effect
 5'      3  -System.Windows.Media.Effects.DropShadowEffect  5(         
BlurRadius$ 5Q�6+      ShadowDepth$ 1Q�6:      	Direction$	 270Q�6J     MaterialDesignShadow   Color# [ 6Z      Opacity$	 .42Q�6�      RenderingBias$ Performance=�6�   5*      9� 5,      -   5         9�Name$ expander��5,      
������ $��Điều hướng��5-      $��Yu Gothic Light)�63    ! MaterialDesignLightForeground#��[ 5.      .��50      �� -   5         ��Name$ scrollViewer��55      $��Stretch=�51      $
��Auto=�52      $��Disabled=�53      ��.   for_scrollviewer#��[ 56       �� PanningMode$ HorizontalOnly=�57       J� SnapsToDevicePixels . 
������ .��5<      ��  �� Orientation$ 
Horizontal=�6%   
������ .+�5?      �� -   5         # MaterialDesignRaisedLightButton#��[ 5?   %   
������ +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5A      ���	#CCD4A9FF$	��220��5E      $��80��6!   $��0q�6-   .��5F   "   �  � ColumnDefinitions 5G   &   �� 5H   *   $
��Auto �6;   �� 5I   *    5K   &   �� 5L   *   $��* �68   �� 5M   *   $
��Auto �68   .+�5P   &   �� $	 10��6-   $��45��6?   $��50��6K   ���	#B2DCCFFF$��2��5Q   4   ._�5R   *   �� $��35��60   $=��7/UngdungHRM;component/icon/icons8_management_60px_6.png��6<   5S   '   �� 5U   &   $��Danh sách nhân viên��60   $��1��5V       
�������$��5 0 0 0q�5X       $��Center=�5Y   $   $��Normal"�6?   $��
Leelawadee)�6S   �� 5Z   &   $��Employee List��60   $��1��5[       $��1��5\   $   
�������$��5 0 0 0q�5^       $��Center=�5_   $   $��Segoe UI Light)�6?   $��Normal"�6[   5`   #   5a      �� 5d      -   5        $��15 0 0 0q�5d   %   #��[ 67   
������ $ 10��5f      ���	#CCF3DA83$	��220��5j      $��80��6!   $��0q�6-   .��5k   "   � $	��185��6'    5l   &   �� 5m   *   $
��Auto �6;   �� 5n   *    5p   &   �� 5q   *   $��* �68   �� 5r   *   $
��Auto �68   .+�5u   &   �� $	 10��6-   $��45��6?   $��50��6K   ���	#99FFEBCF$��2��5v   4   ._�5w   *   �� $��35��60   $?��9/UngdungHRM;component/icon/icons8_test_results_60px_5.png��6<   5x   '   �� 5z   &   $��	Báo cáo��60   $��1��5{       
�������$��5 0 0 0q�5}       $��Center=�5~   $   $��Normal"�6?   $��
Leelawadee)�6S   �� 5   &   $��Reports��60   $��1��5�       $��1��5�   $   
�������$��5 0 0 0q�5�       $��Center=�5�   $   $��Segoe UI Light)�6?   $��Normal"�6[   5�   #   5�      5�      5�      5�      )  #MaterialDesignThemes.Wpf.DialogHost  5�      -   5          Name$ 
dialogHost��5�   ,   $��1��5�   ,   $��0 10 0 0q�5�   ,      DialogContent 5�      � 5�      -   5         �Name$ dialogHostControl��5�      .��5�      � -   5        $ controls��5�      5�      5�      � 5�      -   5        $ controlEdit��5�   (   $��2��6   $y�	Collapsed=�6=   �� 5�      -	   5         ��Name$
 Mess��5�      $��1��6'   $��40��5�      $��	0 0 10 10q�5�      $��Right=�5�      $��Bottom=�5�      ���	#CC0AFF9B$ 20 10q�5�       J� Opacity$ 0Q�5�      $	 5��5�      ._�5�      �� -
   5         ��Name$ 
txtMessage��5�       $��Lưu thành công��64   $��Center=�5�       $��Center=�5�       $��	Noto Sans)�5�       
��� � �5�       5�      5�      5�      5�      5�      