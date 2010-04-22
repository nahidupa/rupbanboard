using System;
using System.Collections.Generic;
using Rupban.Core;
using Rupban.LoginModule.Controller;
using Rupban.LoginModule.Services;
using Rupban.LoginModule.Views;

namespace Rupban.LoginModule.Presenters
{
    public class RupbanBoardPresenter: IRupbanBoardPresenter
    {
        private readonly IRupbanBoardController _rupbanBoardController;
        private readonly IRupbanBoardService _rupbanBoardService;

        private List<TemplateCollum> _columnList;

        public RupbanBoardPresenter(IRupbanBoardView view, IRupbanBoardController rupbanBoardController, IRupbanBoardService rupbanBoardService)
        {
            _rupbanBoardController = rupbanBoardController;
            _rupbanBoardService = rupbanBoardService;
            View = view;
            View.SetModel(this);
            _columnList = _rupbanBoardService.GetTemplateCollumList();
            //_rupbanBoardController.LoadBoardColumnView(_columnList);
           
        }

        public IRupbanBoardView View
        {
            get; set;
        }
    }
}