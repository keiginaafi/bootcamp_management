   M S B A M L   `   `   `  ����M  IBootcampManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:BootcampManagement.UserControlsBootcampManagement.UserControls  5      8    2BootcampManagement.UserControls.Trainer_DailyScore   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?local-clr-namespace:BootcampManagement.UserControls     5      V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5
      � $��0,25,0,0q�6   .+�5   
   �� -   5          ��Name$  Id_Tbox��5      $y�Hidden=�6#   69   �� 5   
   .+�5      �� $
��Wrap=�6   $��0,10,0,0q�6,   $��Daily Score��6>   $��Center=�6Q   $��25(�6n   $��Yu Gothic UI Bold)�6|   5      �� 5   
   $��200,60,200,0q�6   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� .+�5      �� $
��Wrap=�6    $��Class :��64   $��12(�6C   $��Yu Gothic UI Light)�6Q   �� 5      -   5         ��Name$ Class_CMbbox��5      $
��Left=�65   $��	0,5,50,10q�6P   $	��Top=�6c   $	��200��6{   $��Yu Gothic UI Light)�6�   5      �� 5      .+�5      �� $
��Wrap=�6    $��Batch :��64   $��12(�6C   $��Yu Gothic UI Light)�6Q   �� 5      -   5        $ Batch_Cmbbox��5      $
��Left=�65   $��0,5,0,10q�6P   $	��Top=�6b   $	��200��6z   $��Yu Gothic UI Light)�6�   5      5      �� 5      $
��Wrap=�6   $��Name :��6,   $��12(�6:   $��Yu Gothic UI Light)�6H   �� 5      -   5        $ Name_Cmbbox��5      $
��Left=�6,   $��0,5,0,10q�6G   $	��Top=�6Y   $	��450��6q   $��Yu Gothic UI Light)�6}   �� 5      $
��Wrap=�6   $��Score :��6,   $��12(�6;   $��Yu Gothic UI Light)�6I   �� 5      -   5        $  
Score_Tbox��5      $
��Left=�6*   $��0,5,0,10q�6E    �� TextWrapping$
 Wrap=�6W   $	��Top=�6k   $	��450��6�   $��Yu Gothic UI Light)�6�   �� 5      $
��Wrap=�6   $��Date :��6,   $��12(�6:   $��Yu Gothic UI Light)�6H   �� 5      -   5        $  	Date_Tbox��5      $
��Left=�6)   $��0,5,0,10q�6D   $
 Wrap=�6V   $	��Top=�6j   $	��450��6�   $��Yu Gothic UI Light)�6�   �� 5       $ 
Horizontal=�6   $��
63,20,63,0q�62   $��33��6F   .+�5!      �� -   5         ��Name$ 
Insert_Btn��5!      $��Insert��6-   $	��Top=�6>   $
��Left=�6V   $��90��6q   $��30��6|   $��Yu Gothic UI Light)�6�   $��0,0,27,0q�6�   �� 5"      -   5        $ 
Update_Btn��5"      $��Update��6-   $	��Top=�6>   $
��Left=�6V   $��90��6q   $��30��6|   ���#FFCB48���#FFCB48$��Yu Gothic UI Light)�6�   $��0,0,27,0q�6�   �� 5#      -	   5        $ 
Delete_Btn��5#      $��Delete��6-   $	��Top=�6>   $
��Left=�6V   $��90��6q   $��30��6|   ���#e74c3c���#e74c3c$��Yu Gothic UI Light)�6�   5$      5%      �� 5&   
   $��	0,370,0,0q�6   .+�5'      &   System.Windows.Controls.DataGrid  -
   5          Name$ DailyScore_DataGrid��5'      $��Center=�64   $	��Top=�6Q   $	��250��6i   $	��600��6v      AutoGenerateColumns .  $��	34,0,34,0q�6�      Columns 5(      0  *System.Windows.Controls.DataGridTextColumn  5)      ,  &System.Windows.Controls.DataGridColumn   Header$ No��6)   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 40 6L   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 65   �� *Id+6L     5*      $
 Name��6)   $		 250 6P   
 67   �� *Name+6P     5+      $ Score��6)   $	 * 6R   
 68   �� *Score+6R     5,      $
 Date��6)   $	 * 6P   
 67   �� *Date+6P      ColumnHeaderStyle 5.      �� 5/       �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�50      ��  �� Property � �� �� Value$ Center=�6G   �� 51       � ��
 �����67   �� 52       � ��$ 30��63   �� 53       � ��
 �   �67   54      56      57      58      59      