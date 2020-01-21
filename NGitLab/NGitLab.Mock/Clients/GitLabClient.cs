﻿namespace NGitLab.Mock.Clients
{
    internal sealed class GitLabClient : ClientBase, IGitLabClient
    {
        public GitLabClient(ClientContext context)
            : base(context)
        {
        }

        public IGroupsClient Groups => new GroupClient(Context);
        public IUserClient Users => new UserClient(Context);
        public IProjectClient Projects => new ProjectClient(Context);
        public IMembersClient Members => new MembersClient(Context);
        public ICommitClient GetCommits(int projectId) => new CommitClient(Context, projectId);

        public IIssueClient Issues => new IssueClient(Context);
        public ILabelClient Labels => new LabelClient(Context);
        public IRunnerClient Runners => new RunnerClient(Context);
        public IVersionClient Version => new VersionClient(Context);
        public INamespacesClient Namespaces => new NamespacesClient(Context);
        public ISnippetClient Snippets => new SnippetClient(Context);
        public ISystemHookClient SystemHooks => new SystemHookClient(Context);

        public ICommitStatusClient GetCommitStatus(int projectId) => new CommitStatusClient(Context, projectId);
        public IEnvironmentClient GetEnvironmentClient(int projectId) => new EnvironmentClient(Context, projectId);
        public IGroupBadgeClient GetGroupBadgeClient(int groupId) => new GroupBadgeClient(Context, groupId);
        public IGroupVariableClient GetGroupVariableClient(int groupId) => new GroupVariableClient(Context, groupId);
        public IJobClient GetJobs(int projectId) => new JobClient(Context, projectId);
        public IMergeRequestClient GetMergeRequest(int projectId) => new MergeRequestClient(Context, projectId);
        public IMilestoneClient GetMilestone(int projectId) => new MilestoneClient(Context, projectId);
        public IPipelineClient GetPipelines(int projectId) => new PipelineClient(Context, jobClient: GetJobs(projectId), projectId: projectId);
        public IProjectBadgeClient GetProjectBadgeClient(int projectId) => new ProjectBadgeClient(Context, projectId);
        public IProjectIssueNoteClient GetProjectIssueNoteClient(int projectId) => new ProjectIssueNoteClient(Context, projectId);
        public IProjectVariableClient GetProjectVariableClient(int projectId) => new ProjectVariableClient(Context, projectId);
        public IRepositoryClient GetRepository(int projectId) => new RepositoryClient(Context, projectId);
        public ITriggerClient GetTriggers(int projectId) => new TriggerClient(Context, projectId);
        public IWikiClient GetWikiClient(int projectId) => new WikiClient(Context, projectId);
    }
}
