   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WpfApp2.ViewWpfApp2.View  5   	   5clr-namespace:WpfApp2.ViewModelWpfApp2.ViewModel  5   	       WpfApp2.View.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:WpfApp2.View     5   	   .vmclr-namespace:WpfApp2.ViewModel     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)    � DataContext 5      +   %WpfApp2.ViewModel.MainWindowViewModel  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      $
��Auto �6   �� 5      .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      �� 5      �� 5      .+�5       �� -   5        $	��Add��5    %   $��0��6   $��15q�60   $%��Добавить продукт��6<   $��20(�6W   6e   �� 5!      -   5        $��Delete��5!   &   $��1��6   $��15q�64   $#��Удалить продукт��6@   $��20(�6Z   5%      � 5'   
   $��1��6   ���#FFF.+�5*      �� 
������ $��Stretch=�5-      $
��Auto=�5/      ��5+      �� *
Products+ �� UpdateSourceTrigger$ PropertyChanged=���56      �� 58      .R�59      �� $��BRDitem��5:      $	��8,4q�5;      
�������
�����_�$��1q�5>      ._�5@      � $��10q�5A   !    5C   "   �� 5D   &   $	��100 �67   �� 5E   &   �� 5F   &   �� 5G   &   $
��Auto �67   .+�5I   "   �� $��10q�6E   ��6)   �� *
GetPhoto+6E   �� 5J   "   $��1��6-   .+�5K   &   �� $��1��60   ��6@   �� *Title+�� 5L   &   $��2��60   ��6@   �� *Description+5M   #   �� 5Q   "   $��2��6-   .+�5R   &   �� $��2��60   ��6@   �� *Cost+ �� StringFormat$ {0} количество���� 5S   &   $��2��60   ��6@   �� *Manufacturer+�� 5T   &   $��2��60   ��6@   �� *
Discount+5W   #   �� 5Y   "   $
��Edit��6:   -   5        $��3��5Y   )   $��15q�6F   $ ��Редкакировать��5Z   )   $��15(�5[   )   5\   )   5^      5`      5a       � ContextMenu 5d      �� 5e      .@�5g      m� -   5        $	��Add��5g   #   60   m� 5h      -   5        $��Delete��5h   #   63   m� 5i      -   5        $
��Edit��5i   #   61   5k      5p      5w      5y      5z      