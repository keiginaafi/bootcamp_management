   M S B A M L   `   `   `  ����M  IBootcampManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:BootcampManagement.UserControlsBootcampManagement.UserControls  5      2    ,BootcampManagement.UserControls.Trainer_Site   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?local-clr-namespace:BootcampManagement.UserControls     5      V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5
      � $��0,25,0,0q�6   .+�5   
   �� -   5          ��Name$  Id_Tbox��5      $y�Hidden=�6#   69   �� 5   
   .+�5      �� $
��Wrap=�6   $��0,10,0,0q�6,   $��Manage Site��6>   $��Center=�6Q   $��25(�6n   $��Yu Gothic UI Bold)�6|   5      �� 5   
   $��
70,60,70,0q�6    �� Orientation$ 
Horizontal=�6)   .+�5      �� $��0,0,59,0q�6   .+�5      �� $ 
Horizontal=�6   .+�5      �� .+�5      �� $
��Wrap=�6$   $��Class :��68   $��12(�6G   $��Yu Gothic UI Light)�6U   �� 5      -   5         ��Name$ Class_Cmbbox��5   #   $
��Left=�69   $��	0,5,50,10q�6T   $	��Top=�6g   $	��137��6   $��Yu Gothic UI Light)�6�   5      �� 5      .+�5      �� $
��Wrap=�6$   $��Batch :��68   $��12(�6G   $��Yu Gothic UI Light)�6U   �� 5      -   5        $ Batch_Cmbbox��5   #   $
��Left=�69   $��0,5,0,10q�6T   $	��Top=�6f   $	��137��6~   $��Yu Gothic UI Light)�6�   5      5      �� 5      $
��Wrap=�6   $��Name :��60   $��12(�6>   $��Yu Gothic UI Light)�6L   �� 5      -   5        $ Name_Cmbbox��5      $
��Left=�60   $��0,5,0,5q�6K   $	��Top=�6\   $	��325��6t   $��Yu Gothic UI Light)�6�   �� 5      $
��Wrap=�6   $��	Company :��60   $��12(�6A   $��Yu Gothic UI Light)�6O   �� 5      -   5        $ Company_Cmbbox��5      $
��Left=�63   $��0,5,0,5q�6N   $	��Top=�6_   $	��325��6w   $��Yu Gothic UI Light)�6�   �� 5       $
��Wrap=�6   $��
Position :��60   $��12(�6B   $��Yu Gothic UI Light)�6P   �� 5!      -   5        $ Position_Cmbbox��5!      $
��Left=�64   $��0,5,0,5q�6O   $	��Top=�6`   $	��325��6x   $��Yu Gothic UI Light)�6�   5"      �� 5#      .+�5$      �� $
��Wrap=�6   $��Date On Board :��60   $��12(�6G   $��Yu Gothic UI Light)�6U   (  "System.Windows.Controls.DatePicker  5%      -   5          Name$ DateOnBoard_Dpc��5%      $
��Left=�66   $��0,10,0,5q�6Q   $	��Top=�6c   $	��325��6{   $��Yu Gothic UI Light)�6�    � 	Resources 5&      :  4System.Windows.Controls.Primitives.DatePickerTextBox �� 
TargetType �� Property �� Value��%\   '        �� 5'      "  6    .�5(      ��  �@��	MaxLength$ 10��6:   5)      5*      5+      �� 5,      $
��Wrap=�6   $��
Duration :��60   $��12(�6B   $��Yu Gothic UI Light)�6P   �� 5-      -   5        $  Duration_Tbox��5-      $
��Left=�61   $��0,5,0,5q�6L    �� TextWrapping$
 Wrap=�6]   $	��Top=�6q   $	��325��6�   $��Yu Gothic UI Light)�6�   �� 5.      $ 
Horizontal=�6   $��0,25,0,0q�66   $��33��6H   .+�5/      �� -	   5        	 ��Name$	 
Insert_Btn��5/      $��Insert��61   $	��Top=�6B   $
��Left=�6Z   $��90��6u   $��30��6�   $��Yu Gothic UI Light)�6�   $��0,0,27,0q�6�   �� 50      -
   5        $	 
Update_Btn��50      $��Update��61   $	��Top=�6B   $
��Left=�6Z   $��90��6u   $��30��6�   ���#FFCB48���#FFCB48$��Yu Gothic UI Light)�6�   $��0,0,27,0q�6�   �� 51      -   5        $	 
Delete_Btn��51      $��Delete��61   $	��Top=�6B   $
��Left=�6Z   $��90��6u   $��30��6�   ���#e74c3c���#e74c3c$��Yu Gothic UI Light)�6�   52      53      54      �� 55   
   $��	0,310,0,0q�6   .+�56      &   System.Windows.Controls.DataGrid  -   5        
  Name$
 Site_DataGrid��56      $��Center=�6.   $	��Top=�6K   $	��323��6c   $	��600��6p      AutoGenerateColumns .  $��	34,0,34,0q�6�      Columns 57      0  *System.Windows.Controls.DataGridTextColumn  58      ,  &System.Windows.Controls.DataGridColumn   Header$ No��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ 40 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *Id+6L     59      $
 Name��6)   $	 170 6P    67   �� *Name+6P     5:      $ Company��6)   $ * 6V    6:   �� *	Company+6V     5;      $ Position��6)   $ * 6X    6;   �� *
Position+6X     5<      $
 Date��6)   $ * 6Q    67   �� *xDate+6Q     5=      $ Duration��6)   $ * 6X    6;   �� *
Duration+6X      ColumnHeaderStyle 5?      �� 5@      =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5A      ��  � ��$ Center=�6G   �� 5B       � ��
 �����67   �� 5C       � ��$ 30��63   �� 5D       � ��
 �   �67   5E      5G      5H      5I      5J      