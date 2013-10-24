// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   ViewModel.tt
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;
using WPAppStudio;
using WPAppStudio.Controls;
using WPAppStudio.Entities;
using WPAppStudio.Entities.Base;
using WPAppStudio.Localization;
using WPAppStudio.Repositories;
using WPAppStudio.Services;
using WPAppStudio.Services.Interfaces;
using WPAppStudio.Shared;
using WPAppStudio.ViewModel.Base;
using WPAppStudio.ViewModel.Interfaces;

namespace WPAppStudio.ViewModel
{
    /// <summary>
    /// Implementation of ThePlace_Info ViewModel.
    /// </summary>
    [System.Runtime.CompilerServices.CompilerGenerated]
    [System.CodeDom.Compiler.GeneratedCode("Radarc", "4.0")]
    public partial class ThePlace_InfoViewModel : BindableBase, IThePlace_InfoViewModel
    {       

		private readonly IDialogService _dialogService;
		private readonly INavigationService _navigationService;
		private readonly ILockScreenService _lockScreenService;
		private readonly IThePlaceDataSource _thePlaceDataSource;
		private readonly IphotosCollection _photosCollection;
		private readonly IdiaryCollection _diaryCollection;
		private readonly IfellowsCollection _fellowsCollection;
		private readonly ITheNextOneCollection _theNextOneCollection;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="ThePlace_InfoViewModel" /> class.
        /// </summary>
        /// <param name="dialogService">The Dialog Service.</param>
        /// <param name="navigationService">The Navigation Service.</param>
        /// <param name="lockScreenService">The Lock Screen Service.</param>
        /// <param name="thePlaceDataSource">The The Place Data Source.</param>
        /// <param name="photosCollection">The Photos Collection.</param>
        /// <param name="diaryCollection">The Diary Collection.</param>
        /// <param name="fellowsCollection">The Fellows Collection.</param>
        /// <param name="theNextOneCollection">The The Next One Collection.</param>
        public ThePlace_InfoViewModel(IDialogService dialogService, INavigationService navigationService, ILockScreenService lockScreenService, IThePlaceDataSource thePlaceDataSource, IphotosCollection photosCollection, IdiaryCollection diaryCollection, IfellowsCollection fellowsCollection, ITheNextOneCollection theNextOneCollection)
        {
			_dialogService = dialogService;
			_navigationService = navigationService;
			_lockScreenService = lockScreenService;
			_thePlaceDataSource = thePlaceDataSource;
			_photosCollection = photosCollection;
			_diaryCollection = diaryCollection;
			_fellowsCollection = fellowsCollection;
			_theNextOneCollection = theNextOneCollection;
        }
		

		private string _currentThePlace_InfoHtmlControl;

        /// <summary>
        /// CurrentThePlace_InfoHtmlControl property.
        /// </summary>		
        public string CurrentThePlace_InfoHtmlControl
        {
            get
            {
                if(_currentThePlace_InfoHtmlControl == null)
					_currentThePlace_InfoHtmlControl = _thePlaceDataSource.Get();
				return _currentThePlace_InfoHtmlControl;     
            }
            set
            {
                SetProperty(ref _currentThePlace_InfoHtmlControl, value);
            }
        }

		private ObservableCollection<photosCollectionSchema> _photos_AlbumListControlCollection;

        /// <summary>
        /// Photos_AlbumListControlCollection property.
        /// </summary>		
        public ObservableCollection<photosCollectionSchema> Photos_AlbumListControlCollection
        {
            get
            {
                if(_photos_AlbumListControlCollection == null)
					_photos_AlbumListControlCollection = _photosCollection.GetData();
				return _photos_AlbumListControlCollection;     
            }
            set
            {
                SetProperty(ref _photos_AlbumListControlCollection, value);
            }
        }

		private photosCollectionSchema _selectedphotos_AlbumListControlCollection;

        /// <summary>
        /// Selectedphotos_AlbumListControlCollection property.
        /// </summary>		
        public photosCollectionSchema Selectedphotos_AlbumListControlCollection
        {
            get
            {
				return _selectedphotos_AlbumListControlCollection;
            }
            set
            {
                _selectedphotos_AlbumListControlCollection = value;
                if (value != null)
                    _navigationService.NavigateTo<Iphotos_DetailViewModel>(_selectedphotos_AlbumListControlCollection);
            }
        }

		private ObservableCollection<diarySchema> _diary_ListListControlCollection;

        /// <summary>
        /// Diary_ListListControlCollection property.
        /// </summary>		
        public ObservableCollection<diarySchema> Diary_ListListControlCollection
        {
            get
            {
                if(_diary_ListListControlCollection == null)
					_diary_ListListControlCollection = _diaryCollection.GetData();
				return _diary_ListListControlCollection;     
            }
            set
            {
                SetProperty(ref _diary_ListListControlCollection, value);
            }
        }

		private diarySchema _selecteddiary_ListListControlCollection;

        /// <summary>
        /// Selecteddiary_ListListControlCollection property.
        /// </summary>		
        public diarySchema Selecteddiary_ListListControlCollection
        {
            get
            {
				return _selecteddiary_ListListControlCollection;
            }
            set
            {
                _selecteddiary_ListListControlCollection = value;
                if (value != null)
                    _navigationService.NavigateTo<Idiary_DetailViewModel>(_selecteddiary_ListListControlCollection);
            }
        }

		private ObservableCollection<fellowsSchema> _fellows_ListListControlCollection;

        /// <summary>
        /// Fellows_ListListControlCollection property.
        /// </summary>		
        public ObservableCollection<fellowsSchema> Fellows_ListListControlCollection
        {
            get
            {
                if(_fellows_ListListControlCollection == null)
					_fellows_ListListControlCollection = _fellowsCollection.GetData();
				return _fellows_ListListControlCollection;     
            }
            set
            {
                SetProperty(ref _fellows_ListListControlCollection, value);
            }
        }

		private fellowsSchema _selectedfellows_ListListControlCollection;

        /// <summary>
        /// Selectedfellows_ListListControlCollection property.
        /// </summary>		
        public fellowsSchema Selectedfellows_ListListControlCollection
        {
            get
            {
				return _selectedfellows_ListListControlCollection;
            }
            set
            {
                _selectedfellows_ListListControlCollection = value;
                if (value != null)
                    _navigationService.NavigateTo<Ifellows_DetailViewModel>(_selectedfellows_ListListControlCollection);
            }
        }

		private ObservableCollection<TheNextOneSchema> _theNextOne_ListListControlCollection;

        /// <summary>
        /// TheNextOne_ListListControlCollection property.
        /// </summary>		
        public ObservableCollection<TheNextOneSchema> TheNextOne_ListListControlCollection
        {
            get
            {
                if(_theNextOne_ListListControlCollection == null)
					RefreshTheNextOne_ListListControlCollectionDelegate();
				return _theNextOne_ListListControlCollection;     
            }
            set
            {
                SetProperty(ref _theNextOne_ListListControlCollection, value);
            }
        }

		private TheNextOneSchema _selectedTheNextOne_ListListControlCollection;

        /// <summary>
        /// SelectedTheNextOne_ListListControlCollection property.
        /// </summary>		
        public TheNextOneSchema SelectedTheNextOne_ListListControlCollection
        {
            get
            {
				return _selectedTheNextOne_ListListControlCollection;
            }
            set
            {
                _selectedTheNextOne_ListListControlCollection = value;
                if (value != null)
                    _navigationService.NavigateTo<ITheNextOne_DetailViewModel>(_selectedTheNextOne_ListListControlCollection);
            }
        }

        /// <summary>
        /// Delegate method for the RefreshTheNextOne_ListListControlCollection command.
        /// </summary>
        public async void RefreshTheNextOne_ListListControlCollectionDelegate(int pageNumber= 1) 
        {
			try
			{
				LoadingTheNextOne_ListListControlCollection = true;
				TheNextOne_ListListControlCollection = await _theNextOneCollection.GetData();
			}
            catch (Exception ex)
            {
				TheNextOne_ListListControlCollection = null;
		
                Debug.WriteLine(ex.ToString());
                _dialogService.Show(AppResources.DynamicDataError + Environment.NewLine + AppResources.TryAgain);
            }
            finally
            {
				LoadingTheNextOne_ListListControlCollection = false;
			}
        }
		
		
        private bool _loadingTheNextOne_ListListControlCollection;
		
        public bool LoadingTheNextOne_ListListControlCollection
        {
            get { return _loadingTheNextOne_ListListControlCollection; }
            set { SetProperty(ref _loadingTheNextOne_ListListControlCollection, value); }
        }

        private ICommand _refreshTheNextOne_ListListControlCollection;

        /// <summary>
        /// Gets the RefreshTheNextOne_ListListControlCollection command.
        /// </summary>
        public ICommand RefreshTheNextOne_ListListControlCollection
        {
            get { return _refreshTheNextOne_ListListControlCollection = _refreshTheNextOne_ListListControlCollection ?? new DelegateCommand<int>(RefreshTheNextOne_ListListControlCollectionDelegate); }
        }

        /// <summary>
        /// Delegate method for the SetLockScreenCommand command.
        /// </summary>
        public  void SetLockScreenCommandDelegate() 
        {
	
				_lockScreenService.SetLockScreen("LockScreen-fe1d364f-e0e1-4f58-b1bb-0ce2fe67aefa.jpg");
        }
		

        private ICommand _setLockScreenCommand;

        /// <summary>
        /// Gets the SetLockScreenCommand command.
        /// </summary>
        public ICommand SetLockScreenCommand
        {
            get { return _setLockScreenCommand = _setLockScreenCommand ?? new DelegateCommand(SetLockScreenCommandDelegate); }
        }
    }
}