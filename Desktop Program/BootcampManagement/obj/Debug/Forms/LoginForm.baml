   M S B A M L   `   `   `  ����M  IBootcampManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:BootcampManagementBootcampManagement  5   	   "    BootcampManagement.LoginForm   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:BootcampManagement     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  
Login Form��5	   	   $	��500��6   $	��900��6)    � WindowStyle$
 None=�65    � WindowStartupLocation$ CenterScreen=�6H    � 
ResizeMode$ NoResize=�6m   .��5
      � -   5        .+�5   
   � $	��596��6   $
��Left=�6   .+�5      �� -   5         ��Name$4 .___BootcampManagement_component_LoginImage_png��5      $8��2/BootcampManagement;component/Image/LoginImage.png��6L   $
��Fill=�6�   $��0,0,28,0q�6�   5      � 5   
   $	��330��6   $��Right=�6   ���#00003D.+�5      �� .+�5      �� -   5         ��Name$ 	Close_Btn��5      
�������$��Center=�6l    � ToolTip$ Close Application��6�   $��294,0,0,464q�6�   $��36��6�   $��36��6�   ��6,   Z� ��6B   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]   Kind$ Close=�6.   $��25��6;   $��25��6F   $	��-10q�6R   5      5      �� 5      $��0,70,0,0q�6   .+�5      �� -   5        $. (___BootcampManagement_component_user_png��5      $2��,/BootcampManagement;component/Image/user.png��6J   $
��Fill=�6�   $��65��6�   $��65��6�   �� 5      $
��Wrap=�6   $��Login��60   $	��Top=�6=   $��Center=�6U   $��35(�6r   
�������$��Yu Gothic UI Light)�6�   5      �� 5      $��
28,210,0,0q�6   .+�5      �� $
��Left=�6   $��0,0,0,5q�67   $
��Wrap=�6H   $��
Username :��6\   $	��Top=�6n   $��14(�6�   
�������$��Yu Gothic UI Light)�6�   �� 5      -   5         ��Name$ UsernameLogin_Tbox��5      $
��Left=�66   $��35��6Q   )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	  Your Username��6]   
 �� TextWrapping$

 Wrap=�6�   $	��Top=�6�   $	��272��6�   $��14(�6�   ���#f2f2f2$��5,0,0,0q�6�   $��Center=�6�   $��Yu Gothic UI Light)�6  5      �� 5      $��
28,280,0,0q�6   .+�5      �� $
��Left=�6   $��0,0,0,5q�67   $
��Wrap=�6H   $��
Password :��6\   $	��Top=�6n   $��14(�6�   
�������$��Yu Gothic UI Light)�6�   G� 5      -   5         G�Name$ PasswordLogin_Pbox��5      $
��Left=�6:   $��35��6U   $	  Your Password��6a   $	��Top=�6�   $	��272��6�   $��14(�6�   ���#f2f2f2$��5,0,0,0q�6�   $��Center=�6�   $��Yu Gothic UI Light)�6  5      �� 5        �� Orientation$ 
Horizontal=�6   $��
28,370,0,0q�62   .+�5!      �� -   5        $ Register_Btn��5!      $��Register Now��6/   $��
0,0,22.5,0q�6F   $
��Left=�6Z   $	��Top=�6u   $	��125��6�   $��35��6�   ���	#FFD3A32C$��Yu Gothic UI Light)�6�   ��6�   Z� 6�   �� 5"      -   5        $ 	Login_Btn��5"      $��Login��6,   $
��Left=�6<   $	��Top=�6W   $	��125��6o   $��35��6{   $��Yu Gothic UI Light)�6�   ���	#FF1A7AC5��6�   Z� 6�   5#      �� 5$      $ 
Horizontal=�6   $��
28,420,0,0q�62   .+�5%      �� $
��Left=�6   $
��Wrap=�67   $��0,0,3,0q�6K   $��Forgot Your Password?��6\   $	��Top=�6y   $��14(�6�   
�������$��Yu Gothic UI Light)�6�   �� 5&      -	   5         ��Name$ ForgotPassword_Txt��5&      $
��Left=�68   $
��Wrap=�6S   $��
Click Here��6g   $	��Top=�6y   $��14(�6�   ���	#FF7CEDFF � Cursor$
 Hand��6�   $��Yu Gothic UI Light)�6�   5'      5(      5)      5*      